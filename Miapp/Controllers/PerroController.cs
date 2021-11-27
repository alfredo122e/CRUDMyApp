using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using primeraAplicacion.Models;

namespace primeraAplicacion.Controllers
{
    public class PerroController : Controller
    {
        private readonly LibraryContext _context;

        public PerroController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Perro
        public async Task<IActionResult> Index()
        {
            var libraryContext = _context.Perro.Include(p => p.Owner);
            return View(await libraryContext.ToListAsync());
        }

        // GET: Perro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perro = await _context.Perro
                .Include(p => p.Owner)
                .FirstOrDefaultAsync(m => m.perroID == id);
            if (perro == null)
            {
                return NotFound();
            }

            return View(perro);
        }

        // GET: Perro/Create
        public IActionResult Create()
        {
            ViewData["OwnerID"] = new SelectList(_context.Set<Owner>(), "OwnerID", "address");
            return View();
        }

        // POST: Perro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("perroID,nama,raza,age,vaccine,ownerName,telephone,OwnerID")] Perro perro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.Set<Owner>(), "OwnerID", "address", perro.OwnerID);
            return View(perro);
        }

        // GET: Perro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perro = await _context.Perro.FindAsync(id);
            if (perro == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.Set<Owner>(), "OwnerID", "address", perro.OwnerID);
            return View(perro);
        }

        // POST: Perro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("perroID,nama,raza,age,vaccine,ownerName,telephone,OwnerID")] Perro perro)
        {
            if (id != perro.perroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerroExists(perro.perroID))
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
            ViewData["OwnerID"] = new SelectList(_context.Set<Owner>(), "OwnerID", "address", perro.OwnerID);
            return View(perro);
        }

        // GET: Perro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perro = await _context.Perro
                .Include(p => p.Owner)
                .FirstOrDefaultAsync(m => m.perroID == id);
            if (perro == null)
            {
                return NotFound();
            }

            return View(perro);
        }

        // POST: Perro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perro = await _context.Perro.FindAsync(id);
            _context.Perro.Remove(perro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerroExists(int id)
        {
            return _context.Perro.Any(e => e.perroID == id);
        }
    }
}
