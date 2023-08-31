using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using JucarAutopartesAplicacionWeb.Models.ViewModels.RawMaterials;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class AutopartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutopartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Autoparts != null ?
                        View(await _context.Autoparts.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Autoparts'  is null.");
        }

        public IActionResult SiSeCreo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            AutopartsViewModel autopartsView = new AutopartsViewModel();

            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name");
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name");

            return View(autopartsView);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AutopartsViewModel autopartsVM)
        {

            if (ModelState.IsValid)
            {
                bool existenciaAutoparte = await _context.Autoparts.AnyAsync(a => a.Name == autopartsVM.Autopart.Name);

                if (existenciaAutoparte)
                {
                    ModelState.AddModelError("Name", "Ya existe una autoparte con ese nombre.");

                    ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopartsVM.Autopart.SubcategoryID);
                    ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", autopartsVM.AutopartMaterial.RawMaterialID);

                    return View(autopartsVM);
                }

                autopartsVM.Autopart.State = true;
                autopartsVM.Autopart.CreationDate = DateTime.Now;
                autopartsVM.Autopart.ModificationDate = DateTime.Now;

                autopartsVM.Inventory.CreationDate = DateTime.Now;
                autopartsVM.Inventory.UltimateModificationDate = DateTime.Now;

                autopartsVM.PriceHistory.State = true;
                autopartsVM.PriceHistory.CreationDate = DateTime.Now;
                autopartsVM.PriceHistory.ModificationDate = DateTime.Now;


                autopartsVM.AutopartMaterial.CreationDate = DateTime.Now;
                autopartsVM.AutopartMaterial.ModificationDate = DateTime.Now;

                _context.Autoparts.Add(autopartsVM.Autopart);
                await _context.SaveChangesAsync();

                int autopartID = autopartsVM.Autopart.AutopartID;

                autopartsVM.Inventory.AutopartID = autopartID;
                autopartsVM.PriceHistory.AutopartID = autopartID;
                autopartsVM.AutopartMaterial.AutopartID = autopartID;

                _context.Inventories.Add(autopartsVM.Inventory);
                _context.PriceHistories.Add(autopartsVM.PriceHistory);
                _context.AutopartMaterials.Add(autopartsVM.AutopartMaterial);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
                //return RedirectToAction(nameof(SiSeCreo));

            }
            ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopartsVM.Autopart.SubcategoryID);
            ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", autopartsVM.AutopartMaterial.RawMaterialID);

            return View(autopartsVM);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
			ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name");
			ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name");

			var autopart = await _context.Autoparts
	            .Include(a => a.Inventory)
	            .Include(a => a.PriceHistories)
	            .Include(a => a.AutopartMaterials)
	            .FirstOrDefaultAsync(a => a.AutopartID == id);

			if (autopart == null)
			{
				return NotFound();
			}

            var autoPartsViewModel = new AutopartsViewModel
            {
                Autopart = autopart,
                Inventory = autopart.Inventory,
                PriceHistory = autopart.PriceHistories.FirstOrDefault(),
                AutopartMaterial = autopart.AutopartMaterials.FirstOrDefault(),
			};

			return View(autoPartsViewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(AutopartsViewModel autopartVM)
        {
            if (ModelState.IsValid)
            {
                
            }
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
