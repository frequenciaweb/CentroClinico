using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CentroClinico.Dominio.Entidades;
using CentroClinico.Infra.Banco.EF;

namespace CentroClinico.Apresentacao.MVC.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly EFContext _context;

        public ConsultasController(EFContext context)
        {
            _context = context;
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
