using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly ejemplocontext _context;

        public TelefonoController(ejemplocontext context)
        {
            _context = context;
        }

        // GET: Telefono
        public async Task<IActionResult> Index()
        {
            var ejemplocontext = _context.Telefono.Include(t => t.Creadores);
            return View(await ejemplocontext.ToListAsync());
        }

        // GET: Telefono/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telefono = await _context.Telefono
                .Include(t => t.Creadores)
                .FirstOrDefaultAsync(m => m.TelefonoId == id);
            if (telefono == null)
            {
                return NotFound();
            }

            return View(telefono);
        }

        // GET: Telefono/Create
        public IActionResult Create()
        {
            ViewData["CreadorID"] = new SelectList(_context.Creador, "creadorId", "Apellido");
            return View();
        }

        // POST: Telefono/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TelefonoId,nombre,Marca,Color,CreadorID")] Telefono telefono)
        {
            if (ModelState.IsValid)
            {
                _context.Add(telefono);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreadorID"] = new SelectList(_context.Creador, "creadorId", "Apellido", telefono.CreadorID);
            return View(telefono);
        }

        // GET: Telefono/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telefono = await _context.Telefono.FindAsync(id);
            if (telefono == null)
            {
                return NotFound();
            }
            ViewData["CreadorID"] = new SelectList(_context.Creador, "creadorId", "Apellido", telefono.CreadorID);
            return View(telefono);
        }

        // POST: Telefono/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TelefonoId,nombre,Marca,Color,CreadorID")] Telefono telefono)
        {
            if (id != telefono.TelefonoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(telefono);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelefonoExists(telefono.TelefonoId))
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
            ViewData["CreadorID"] = new SelectList(_context.Creador, "creadorId", "Apellido", telefono.CreadorID);
            return View(telefono);
        }

        // GET: Telefono/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telefono = await _context.Telefono
                .Include(t => t.Creadores)
                .FirstOrDefaultAsync(m => m.TelefonoId == id);
            if (telefono == null)
            {
                return NotFound();
            }

            return View(telefono);
        }

        // POST: Telefono/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var telefono = await _context.Telefono.FindAsync(id);
            _context.Telefono.Remove(telefono);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TelefonoExists(int id)
        {
            return _context.Telefono.Any(e => e.TelefonoId == id);
        }
    }
}
