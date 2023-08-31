using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class MovementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movements.Include(m => m.RawMaterial);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Movements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movements == null)
            {
                return NotFound();
            }

            var movement = await _context.Movements
                .Include(m => m.RawMaterial)
                .FirstOrDefaultAsync(m => m.MovementID == id);
            if (movement == null)
            {
                return NotFound();
            }

            return View(movement);
        }

        // GET: Movements/Create
        public IActionResult Create()
        {
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name");
            return View();
        }

        // POST: Movements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovementID,Quantity,MovementType,MovementDate,CreationDate,ModificationDate,RawMaterialID")] Movement movement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", movement.RawMaterialID);
            return View(movement);
        }

        // GET: Movements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Movements == null)
            {
                return NotFound();
            }

            var movement = await _context.Movements.FindAsync(id);
            if (movement == null)
            {
                return NotFound();
            }
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", movement.RawMaterialID);
            return View(movement);
        }

        // POST: Movements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovementID,Quantity,MovementType,MovementDate,CreationDate,ModificationDate,RawMaterialID")] Movement movement)
        {
            if (id != movement.MovementID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovementExists(movement.MovementID))
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
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", movement.RawMaterialID);
            return View(movement);
        }

        // GET: Movements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movements == null)
            {
                return NotFound();
            }

            var movement = await _context.Movements
                .Include(m => m.RawMaterial)
                .FirstOrDefaultAsync(m => m.MovementID == id);
            if (movement == null)
            {
                return NotFound();
            }

            return View(movement);
        }

        // POST: Movements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movements == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Movements'  is null.");
            }
            var movement = await _context.Movements.FindAsync(id);
            if (movement != null)
            {
                _context.Movements.Remove(movement);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovementExists(int id)
        {
          return (_context.Movements?.Any(e => e.MovementID == id)).GetValueOrDefault();
        }
    }
}
