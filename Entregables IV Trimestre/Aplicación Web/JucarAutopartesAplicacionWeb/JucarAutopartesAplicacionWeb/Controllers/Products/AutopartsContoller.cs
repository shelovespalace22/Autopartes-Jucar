using AutoMapper;
using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts;
using JucarAutopartesAplicacionWeb.Services.Automapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class AutopartsContoller : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AutopartsContoller(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create() 
        {
            AutopartsViewModel autopartsVWM = new AutopartsViewModel();
            return View(autopartsVWM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AutopartsViewModel autopartsView)
        {
            if (ModelState.IsValid)
            {
                //Mapear objetos

                var autopart = _mapper.Map<AutopartsViewModel, Autopart>(autopartsView);
                var autopartMaterial = _mapper.Map<AutopartsViewModel, AutopartMaterial>(autopartsView);
                var inventory = _mapper.Map<AutopartsViewModel, Inventory>(autopartsView);
                var priceHistory = _mapper.Map<AutopartsViewModel, PriceHistory>(autopartsView);

                ViewData["SubcategoryID"] = new SelectList(_context.Subcategories, "SubcategoryID", "Name", autopart.SubcategoryID);

                //Inicializar propiedades Autopart

                autopart.State = true;
                autopart.CreationDate = DateTime.Now;
                autopart.ModificationDate = DateTime.Now;

                //Inicializar propiedades AutopartMaterial

                autopartMaterial.CreationDate = DateTime.Now;
                autopartMaterial.ModificationDate = DateTime.Now;

                //Inicializar propiedades Inventory

                inventory.CreationDate = DateTime.Now;
                inventory.UltimateModificationDate = DateTime.Now;

                //Inicializar propiedades PriceHistory

                priceHistory.State = true;
                priceHistory.CreationDate = DateTime.Now;
                priceHistory.ModificationDate = DateTime.Now;

                //Generar instancias en los modelos correspondientes

                _context.Add(autopart);
                _context.Add(inventory);
                _context.Add(priceHistory);
                _context.Add(autopartMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(autopartsView);
        }


    }
}
