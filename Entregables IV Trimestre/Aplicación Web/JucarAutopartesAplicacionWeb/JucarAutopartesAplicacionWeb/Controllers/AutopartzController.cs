using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Controllers
{
    public class AutopartzController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutopartzController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Autopartz
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Autoparts.Include(a => a.Subcategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Autopartz/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Autoparts == null)
            {
                return NotFound();
            }

            var autopart = await _context.Autoparts
                .Include(a => a.Subcategory)
                .FirstOrDefaultAsync(m => m.AutopartID == id);
            if (autopart == null)
            {
                return NotFound();
            }

            return View(autopart);
        }

        // GET: Autopartz/Create
        public IActionResult Create()
        {
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name");
            return View();
        }

        // POST: Autopartz/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutopartID,Name,Description,WeightKgs,HeightCm,LengthCm,VehicleZone,State,CreationDate,ModificationDate,SubcategoryID")] Autopart autopart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autopart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopart.SubcategoryID);
            return View(autopart);
        }

        // GET: Autopartz/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Autoparts == null)
            {
                return NotFound();
            }

            var autopart = await _context.Autoparts.FindAsync(id);
            if (autopart == null)
            {
                return NotFound();
            }
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopart.SubcategoryID);
            return View(autopart);
        }

        // POST: Autopartz/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutopartID,Name,Description,WeightKgs,HeightCm,LengthCm,VehicleZone,State,CreationDate,ModificationDate,SubcategoryID")] Autopart autopart)
        {
            if (id != autopart.AutopartID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autopart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutopartExists(autopart.AutopartID))
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
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopart.SubcategoryID);
            return View(autopart);
        }

        // GET: Autopartz/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Autoparts == null)
            {
                return NotFound();
            }

            var autopart = await _context.Autoparts
                .Include(a => a.Subcategory)
                .FirstOrDefaultAsync(m => m.AutopartID == id);
            if (autopart == null)
            {
                return NotFound();
            }

            return View(autopart);
        }

        // POST: Autopartz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Autoparts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Autoparts'  is null.");
            }
            var autopart = await _context.Autoparts.FindAsync(id);
            if (autopart != null)
            {
                _context.Autoparts.Remove(autopart);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutopartExists(int id)
        {
          return (_context.Autoparts?.Any(e => e.AutopartID == id)).GetValueOrDefault();
        }
    }
}
