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
    public class ConsultoriosController : Controller
    {
        private readonly EFContext _context;

        public ConsultoriosController(EFContext context)
        {
            _context = context;
        }

        // GET: Consultorios
        public async Task<IActionResult> Index()
        {
            var eFContext = _context.Consultorios.Include(c => c.Unidade);
            return View(await eFContext.ToListAsync());
        }

        // GET: Consultorios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultorio = await _context.Consultorios
                .Include(c => c.Unidade)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consultorio == null)
            {
                return NotFound();
            }

            return View(consultorio);
        }

        // GET: Consultorios/Create
        public IActionResult Create()
        {
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP");
            return View();
        }

        // POST: Consultorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Sala,Andar,UnidadeID")] Consultorio consultorio)
        {
            if (ModelState.IsValid)
            {
                consultorio.ID = Guid.NewGuid();
                _context.Add(consultorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consultorio.UnidadeID);
            return View(consultorio);
        }

        // GET: Consultorios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultorio = await _context.Consultorios.FindAsync(id);
            if (consultorio == null)
            {
                return NotFound();
            }
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consultorio.UnidadeID);
            return View(consultorio);
        }

        // POST: Consultorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Sala,Andar,UnidadeID")] Consultorio consultorio)
        {
            if (id != consultorio.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultorioExists(consultorio.ID))
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
            ViewData["UnidadeID"] = new SelectList(_context.Unidades, "ID", "CEP", consultorio.UnidadeID);
            return View(consultorio);
        }

        // GET: Consultorios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultorio = await _context.Consultorios
                .Include(c => c.Unidade)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consultorio == null)
            {
                return NotFound();
            }

            return View(consultorio);
        }

        // POST: Consultorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var consultorio = await _context.Consultorios.FindAsync(id);
            _context.Consultorios.Remove(consultorio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultorioExists(Guid id)
        {
            return _context.Consultorios.Any(e => e.ID == id);
        }
    }
}
