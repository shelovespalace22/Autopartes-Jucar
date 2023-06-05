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
    public class SubcategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubcategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Subcategories
        public async Task<IActionResult> Index()
        {
            return _context.Subcategories != null ?
                          View(await _context.Subcategories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Subcategories'  is null.");
        }

        // GET: Subcategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subcategories == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.SubcategoryID == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            return View(subcategory);
        }

        // GET: Subcategories/Create
        public async Task<IActionResult> Create()
        {
            // Obtener la lista de categorías desde la base de datos
            var categories = await _context.Categories.ToListAsync();

            if (categories.Count == 0)
            {
                // Si no hay categorías, mostrar un mensaje de error o realizar alguna acción
                ModelState.AddModelError(string.Empty, "No hay categorías disponibles.");
            }
            else
            {
                // Si hay categorías, configurar ViewBag.Categories con la lista de categorías
                ViewBag.Categories = new SelectList(categories, "CategoryID", "CategoryName");
            }

            return View();
        }

        // POST: Subcategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubcategoryID,SubcategoryName,CategoryID")] Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                var existingSubcategory = await _context.Subcategories.FirstOrDefaultAsync(c => c.SubcategoryName == subcategory.SubcategoryName);

                if (existingSubcategory != null)
                {
                    ModelState.AddModelError(string.Empty, "¡La subctagoria ya existe!");
                    return View(subcategory);
                }
                else
                {
                    subcategory.State = true;
                    subcategory.CreationDate = DateTime.Now;
                    subcategory.ModificationDate = DateTime.Now;

                    _context.Add(subcategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            // Obtener la lista de categorías desde la base de datos
            var categories = await _context.Categories.ToListAsync();

            if (categories.Count == 0)
            {
                // Si no hay categorías, mostrar un mensaje de error o realizar alguna acción
                ModelState.AddModelError(string.Empty, "No hay categorías disponibles.");
            }
            else
            {
                // Si hay categorías, configurar ViewBag.Categories con la lista de categorías
                ViewBag.Categories = new SelectList(categories, "CategoryID", "CategoryName");
            }

            return View(subcategory);
        }


        // GET: Subcategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Subcategories == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories.FindAsync(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", subcategory.CategoryID);
            return View(subcategory);
        }

        // POST: Subcategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubcategoryID,SubcategoryName,State,CreationDate,ModificationDate,CategoryID")] Subcategory subcategory)
        {
            if (id != subcategory.SubcategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subcategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubcategoryExists(subcategory.SubcategoryID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", subcategory.CategoryID);
            return View(subcategory);
        }

        // GET: Subcategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Subcategories == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.SubcategoryID == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            return View(subcategory);
        }

        // POST: Subcategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Subcategories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Subcategories'  is null.");
            }
            var subcategory = await _context.Subcategories.FindAsync(id);
            if (subcategory != null)
            {
                _context.Subcategories.Remove(subcategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubcategoryExists(int id)
        {
          return (_context.Subcategories?.Any(e => e.SubcategoryID == id)).GetValueOrDefault();
        }
    }
}
