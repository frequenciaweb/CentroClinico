using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CentroClinico.Dominio.Entidades;
using CentroClinico.Infra.Banco.EF;
using Microsoft.AspNetCore.Http;

namespace CentroClinico.Apresentacao.MVC.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly EFContext _context;

        public ConsultasController(EFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Confirmacao(Guid id)
        {
            var consulta = _context.Consultas
                .Include(x => x.Medico)
                .Include(x => x.Medico.Usuario)
                .Include(x => x.Cliente)
                .Include(x => x.Cliente.Usuario)
                .Include(x => x.Unidade)
                .Include(x => x.Especialidade)
                .FirstOrDefault(x => x.ID == id);
            return View(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> Agendamento(Consulta consulta, IFormCollection form)
        {
            ViewBag.UnidadesCadastradas = null;
            ViewBag.MedicosNaUnidade = null;
            ViewBag.Especialidades = null;

            TimeSpan horario = new TimeSpan(0, 0, 0);
            if (form != null)
            {
                TimeSpan.TryParse(form["horario"], out horario);
            }

            consulta.DataHora = consulta.DataHora + horario;

            List<DateTime> horariosDisponiveis = new List<DateTime>();
            DateTime dataInicial = new DateTime(consulta.DataHora.Year, consulta.DataHora.Month, consulta.DataHora.Day, 7, 40, 0);
            while (horariosDisponiveis.Count < 33)
            {
                dataInicial = dataInicial.AddMinutes(20);
                horariosDisponiveis.Add(dataInicial);
            }

            List<DateTime> marcacoes = _context.Consultas
                .Where(x => x.DataHora >= consulta.DataHora
                && x.DataHora <= dataInicial
                && x.MedicoID == consulta.MedicoID
                && x.UnidadeID == consulta.UnidadeID)
                .Select(x => x.DataHora)
                .ToList();

            horariosDisponiveis
                .RemoveAll(x => marcacoes.Contains(x));

            ViewBag.HorasDisponiveis = horariosDisponiveis.OrderBy(x => x)
                .Select(x => new SelectListItem
                {
                    Text = x.ToString("HH:mm:ss"),
                    Value = x.ToString("HH:mm:ss")
                });


            if (consulta.DataHora >= DateTime.Now.AddHours(2)
                    && consulta.DataHora.Hour != 0
                    && consulta.UnidadeID != Guid.Empty
                    && consulta.MedicoID != Guid.Empty
                    && consulta.EspecialidadeID != Guid.Empty
                )
            {
                _context.Consultas.Add(consulta);
                _context.SaveChanges();
                return RedirectToAction("Confirmacao", new { id = consulta.ID });
            }

            if (consulta.UnidadeID != Guid.Empty)
            {
                List<MedicoUnidade> medicoUnidades = _context.MedicoUnidades
                                             .Include(x => x.Medico.Usuario)
                                             .Include(x => x.Medico.Especialidades)
                                             .OrderBy(x => x.Medico.Usuario.Nome)
                                             .Where(x => x.UnidadeID == consulta.UnidadeID)
                                             .ToList();


                if (consulta.EspecialidadeID != Guid.Empty)
                {
                    List<MedicoUnidade> medicosPorEspecialidade = new List<MedicoUnidade>();
                    medicoUnidades.ForEach(medicoUnidade =>
                    {
                        if (medicoUnidade.Medico.Especialidades.Any(x => x.EspecialidadeID == consulta.EspecialidadeID))
                        {
                            medicosPorEspecialidade.Add(medicoUnidade);
                        }
                    });

                    medicoUnidades = medicosPorEspecialidade;
                }


                ViewBag.MedicosNaUnidade = medicoUnidades.Select(
                             x => new SelectListItem
                             {
                                 Text = x.Medico.Usuario.Nome,
                                 Value = x.MedicoID.ToString()
                             })
                             .ToList();
            }


            ViewBag.UnidadesCadastradas = _context.Unidades.OrderBy(x => x.Cidade)
            .ToList()
            .Select(
            x => new SelectListItem
            {
                Text = x.Cidade,
                Value = x.ID.ToString()
            })
            .ToList();

            return View(consulta);
        }


        // GET: Consultas
        public async Task<IActionResult> Index()
        {
            var eFContext = _context.Consultas.Include(c => c.Cliente).Include(c => c.Medico).Include(c => c.Unidade);
            return View(await eFContext.ToListAsync());
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Medico)
                .Include(c => c.Unidade)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        public IActionResult Create()
        {
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "ID");
            ViewData["MedicoID"] = new SelectList(_context.Medicos, "ID", "CPF");
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP");
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MedicoID,DataHora,UnidadeID,ClienteID")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                consulta.ID = Guid.NewGuid();
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "ID", consulta.ClienteID);
            ViewData["MedicoID"] = new SelectList(_context.Medicos, "ID", "CPF", consulta.MedicoID);
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consulta.UnidadeID);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "ID", consulta.ClienteID);
            ViewData["MedicoID"] = new SelectList(_context.Medicos, "ID", "CPF", consulta.MedicoID);
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consulta.UnidadeID);
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,MedicoID,DataHora,UnidadeID,ClienteID")] Consulta consulta)
        {
            if (id != consulta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "ID", consulta.ClienteID);
            ViewData["MedicoID"] = new SelectList(_context.Medicos, "ID", "CPF", consulta.MedicoID);
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consulta.UnidadeID);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Medico)
                .Include(c => c.Unidade)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(Guid id)
        {
            return _context.Consultas.Any(e => e.ID == id);
        }
    }
}
