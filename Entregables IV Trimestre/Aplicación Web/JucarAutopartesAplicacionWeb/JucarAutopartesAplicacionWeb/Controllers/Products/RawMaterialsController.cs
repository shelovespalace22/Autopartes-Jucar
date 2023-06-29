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

        public async Task<IActionResult> Edit(int? id)
        {
            var rawMaterial = await _context.RawMaterials.Include(r => r.Stocks).FirstOrDefaultAsync(r => r.RawMaterialID == id);

            if (rawMaterial == null)
            {
                return NotFound();
            }

            var viewModel = new RawMaterialsViewModel
            {
                RawMaterial = rawMaterial,
                Stock = rawMaterial.Stocks.FirstOrDefault()
            };

            return View(viewModel);
        }


        /* METODO EDIT(POST) PARA PROCESAR DATOS DE VISTA EDIT Y ACTUALIZAR REGISTRO */

        [HttpPost]
        public async Task<IActionResult> Edit(RawMaterialsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                //Encontrar el RawMaterial a actualizar según el RawMaterialID proporcionado desde la vista.

                var rawMaterialToUpdate = await _context.RawMaterials.Include(r => r.Stocks).FirstOrDefaultAsync(r => r.RawMaterialID == viewModel.RawMaterial.RawMaterialID);

                if (rawMaterialToUpdate == null)
                {
                    return NotFound();
                }

                // Actualizar los datos del RawMaterial

                rawMaterialToUpdate.Name = viewModel.RawMaterial.Name;
                rawMaterialToUpdate.Type = viewModel.RawMaterial.Type;
                rawMaterialToUpdate.ModificationDate = DateTime.Now;

                // Actualizar los datos del Stock asociado al RawMaterial

                if (rawMaterialToUpdate.Stocks.Any())
                {
                    var stockUpdate = rawMaterialToUpdate.Stocks.First();

                    stockUpdate.QuantityAvailable = viewModel.Stock.QuantityAvailable;
                    stockUpdate.InitialStock = viewModel.Stock.InitialStock;
                    stockUpdate.ReorderPoint = viewModel.Stock.ReorderPoint;
                    stockUpdate.MinimumInventory = viewModel.Stock.MinimumInventory;
                    stockUpdate.MaximumInventory = viewModel.Stock.MaximumInventory;
                    stockUpdate.ModificationDate = rawMaterialToUpdate.ModificationDate;
                }
                else
                {
                    // Si no hay un Stock existente, crear uno nuevo y establecer la relación con RawMaterial

                    var newStock = new Stock
                    {
                        QuantityAvailable = viewModel.Stock.QuantityAvailable,
                        InitialStock = viewModel.Stock.InitialStock,
                        ReorderPoint = viewModel.Stock.ReorderPoint,
                        MinimumInventory = viewModel.Stock.MinimumInventory,
                        MaximumInventory = viewModel.Stock.MaximumInventory,
                        CreationDate = DateTime.Now,
                        ModificationDate = DateTime.Now,
                    };

                    rawMaterialToUpdate.Stocks.Add(newStock);
                }

                // Guardar los cambios en el contexto y la base de datos

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        /* METODO DETAILS PARA VER EL VALOR DE LAS INSTANCIAS */

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            var rawMaterial = await _context.RawMaterials.Include(r => r.Stocks).FirstOrDefaultAsync(r => r.RawMaterialID == id);

            if (rawMaterial == null)
            {
                return NotFound();
            }

            var viewModel = new RawMaterialsViewModel
            {
                RawMaterial = rawMaterial,
                Stock = rawMaterial.Stocks.FirstOrDefault()
            };

            return View(viewModel);
        }

        /* METODO DELETE PARA ELIMINAR INSTANCIAS*/

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var rawMaterial = _context.RawMaterials
                .Include(r => r.Stocks)
                .FirstOrDefault(r => r.RawMaterialID == id);

            if (rawMaterial == null)
            {
                return NotFound();
            }

            var viewModel = new RawMaterialsViewModel
            {
                RawMaterial = rawMaterial,
                Stock = rawMaterial.Stocks.FirstOrDefault()
            };

            return View(viewModel);
        }

        /* METODO DELETECONFIRMED PARA CONFIRMAR LA ELIMINACION*/

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var rawMaterial = _context.RawMaterials.Find(id);

            if (rawMaterial == null)
            {
                return NotFound();
            }

            var stock = _context.Stocks.FirstOrDefault(s => s.RawMaterialID == id);
            if (stock != null)
            {
                _context.Stocks.Remove(stock);
            }

            _context.RawMaterials.Remove(rawMaterial);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
