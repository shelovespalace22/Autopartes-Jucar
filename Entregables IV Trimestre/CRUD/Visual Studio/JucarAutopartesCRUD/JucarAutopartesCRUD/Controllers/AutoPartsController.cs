using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JucarAutopartesCRUD.Data;
using JucarAutopartesCRUD.Models;

namespace JucarAutopartesCRUD.Controllers
{
    public class AutoPartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutoPartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AutoParts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AutoParts.Include(a => a.Subcategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AutoParts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AutoParts == null)
            {
                return NotFound();
            }

            var autoPart = await _context.AutoParts
                .Include(a => a.Subcategory)
                .FirstOrDefaultAsync(m => m.AutoPartID == id);
            if (autoPart == null)
            {
                return NotFound();
            }

            return View(autoPart);
        }

        // GET: AutoParts/Create
        public IActionResult Create()
        {
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "SubcategoryName");
            return View();
        }

        // POST: AutoParts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoPartID,Name,Performance,WeightKgs,HeightCms,LenghtCms,VehicleZone,State,CreationDate,ModificationDate,SubcategoryID")] AutoPart autoPart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoPart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "SubcategoryName", autoPart.SubcategoryID);
            return View(autoPart);
        }

        // GET: AutoParts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AutoParts == null)
            {
                return NotFound();
            }

            var autoPart = await _context.AutoParts.FindAsync(id);
            if (autoPart == null)
            {
                return NotFound();
            }
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "SubcategoryName", autoPart.SubcategoryID);
            return View(autoPart);
        }

        // POST: AutoParts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoPartID,Name,Performance,WeightKgs,HeightCms,LenghtCms,VehicleZone,State,CreationDate,ModificationDate,SubcategoryID")] AutoPart autoPart)
        {
            if (id != autoPart.AutoPartID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoPart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoPartExists(autoPart.AutoPartID))
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
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "SubcategoryName", autoPart.SubcategoryID);
            return View(autoPart);
        }

        // GET: AutoParts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AutoParts == null)
            {
                return NotFound();
            }

            var autoPart = await _context.AutoParts
                .Include(a => a.Subcategory)
                .FirstOrDefaultAsync(m => m.AutoPartID == id);
            if (autoPart == null)
            {
                return NotFound();
            }

            return View(autoPart);
        }

        // POST: AutoParts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AutoParts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AutoParts'  is null.");
            }
            var autoPart = await _context.AutoParts.FindAsync(id);
            if (autoPart != null)
            {
                _context.AutoParts.Remove(autoPart);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoPartExists(int id)
        {
          return (_context.AutoParts?.Any(e => e.AutoPartID == id)).GetValueOrDefault();
        }
    }
}
