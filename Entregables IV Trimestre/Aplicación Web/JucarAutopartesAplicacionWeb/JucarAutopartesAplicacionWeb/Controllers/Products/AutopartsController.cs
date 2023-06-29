using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class AutopartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutopartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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

				//return RedirectToAction(nameof(Index));
				return RedirectToAction(nameof(SiSeCreo));

			}
			ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopartsVM.Autopart.SubcategoryID);
			ViewData["RawMaterialID"] = new SelectList(_context.RawMaterials, "RawMaterialID", "Name", autopartsVM.AutopartMaterial.RawMaterialID);

			return View(autopartsVM);
        }
    }
}
