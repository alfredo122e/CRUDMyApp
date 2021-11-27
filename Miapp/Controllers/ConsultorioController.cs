using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Miapp.Models;

namespace Miapp.Controllers
{
    public class ConsultoryController : Controller
    {
        private readonly ConsultoryContext _context;

        public ConsultoryController(ConsultoryContext context)
        {
            _context = context;
        }

        // GET: Municipio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consultory.ToListAsync());
        }

        // GET: Municipio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultory = await _context.Consultory
                .FirstOrDefaultAsync(m => m.IDPaciente == id);
            if (consultory == null)
            {
                return NotFound();
            }

            return View(consultory);
        }

        
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPaciente,Nombre,Enfermedad,Medicina")] Consultory consultory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consultory);
        }

        // GET: Municipio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var IDPaciente = await _context.Consultory.FindAsync(id);
            if (IDPaciente == null)
            {
                return NotFound();
            }
            return View(IDPaciente);
        }

        // POST: Municipio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPaciente,Nombre,Enfermedad,Medicina")] Consultory consultory)
        {
            if (id != consultory.IDPaciente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MunicipioExists(consultory.IDPaciente))
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
            return View(consultory);
        }

        // GET: Municipio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipio = await _context.Consultory
                .FirstOrDefaultAsync(m => m.IDPaciente == id);
            if (municipio == null)
            {
                return NotFound();
            }

            return View(municipio);
        }

        // POST: Municipio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var municipio = await _context.Consultory.FindAsync(id);
            _context.Consultory.Remove(municipio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MunicipioExists(int id)
        {
            return _context.Consultory.Any(e => e.IDPaciente == id);
        }
    }
}
