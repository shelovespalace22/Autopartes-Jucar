using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.ViewModels.RawMaterials;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class RawMaterialsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RawMaterialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /* METODO INDEX PARA VISUALIZAR REGISTROS DE MATERIAS PRIMAS */

        public async Task<IActionResult> Index()
        {
            return _context.RawMaterials != null ?
                        View(await _context.RawMaterials.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.RawMaterials'  is null.");
        }

        /* METODO CREATE PARA VISUALIZAR VISTA DE REGISTRO DE MATERIA PRIMA */

        [HttpGet]
        public IActionResult Create()
        {
            RawMaterialsViewModel rmViewModel = new RawMaterialsViewModel();
            return View(rmViewModel);
        }

        /* METODO CREATE(POST) PARA PROCESAR DATOS DE VISTA CREATE */

        [HttpPost]
        public async Task<IActionResult> Create(RawMaterialsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //Verificar si la caegoria ya existe 
                bool existenciaMP = await _context.Categories.AnyAsync(c => c.Name == viewModel.RawMaterial.Name);

                if (existenciaMP)
                {
                    ModelState.AddModelError("Name", "Ya existe una materia prima con ese nombre.");
                    return View(viewModel);
                }

                viewModel.RawMaterial.State = true;
                viewModel.RawMaterial.CreationDate = DateTime.Now;
                viewModel.RawMaterial.ModificationDate = DateTime.Now;

                _context.RawMaterials.Add(viewModel.RawMaterial);
                await _context.SaveChangesAsync();

                viewModel.Stock.CreationDate = DateTime.Now;
                viewModel.Stock.ModificationDate = DateTime.Now;
                int rawMaterialId = viewModel.RawMaterial.RawMaterialID;
                viewModel.Stock.RawMaterialID = rawMaterialId;

                _context.Stocks.Add(viewModel.Stock);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        /* METODO EDIT PARA VISUALIZAR VISTA DE EDITAR UN REGISTRO */

        

        /* METODO EDIT(POST) PARA PROCESAR DATOS DE VISTA EDIT Y ACTUALIZAR REGISTRO */


        
    }
}
