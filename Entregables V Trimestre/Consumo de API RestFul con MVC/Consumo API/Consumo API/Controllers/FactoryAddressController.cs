


using Entities.Models.Factories;
using Microsoft.AspNetCore.Mvc;
using Consumo_API;



namespace Consumo_API.Controllers
{
    public class FactoryAddressesController : Controller
    {
        private readonly HttpClient _client;

        public FactoryAddressesController()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7184/api/factoryaddresses")
            };
        }

        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _client.GetAsync("factoryaddresses");

            if (response.IsSuccessStatusCode)
            {
                var factoryAddresses = await response.Content.ReadAsAsync<List<FactoryAddressViewModel>>();
                return View(factoryAddresses);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error de servidor. Por favor, contacta al administrador.");
                return View(Enumerable.Empty<FactoryAddressViewModel>());
            }
        }

        public IActionResult Details(Guid id)
        {
            // Implementar la lógica para mostrar los detalles de una dirección de fábrica según el ID
            return View();
        }

        public IActionResult Create()
        {
            // Mostrar el formulario de creación de dirección de fábrica
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FactoryAddressViewModel factoryAddress)
        {
            if (ModelState.IsValid)
            {
                var response = await _client.PostAsJsonAsync("factoryaddresses", factoryAddress);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al crear la dirección de fábrica. Por favor, inténtalo de nuevo.");
                }
            }

            return View(factoryAddress);
        }

        public IActionResult Edit(Guid id)
        {
            // Implementar la lógica para mostrar el formulario de edición según el ID
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, FactoryAddressViewModel factoryAddress)
        {
            if (ModelState.IsValid)
            {
                var response = await _client.PutAsJsonAsync($"factoryaddresses/{id}", factoryAddress);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al editar la dirección de fábrica. Por favor, inténtalo de nuevo.");
                }
            }

            return View(factoryAddress);
        }

        public IActionResult Delete(Guid id)
        {
            // Implementar la lógica para mostrar la confirmación de eliminación según el ID
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var response = await _client.DeleteAsync($"factoryaddresses/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar la dirección de fábrica. Por favor, inténtalo de nuevo.");
                return View();
            }
        }
    }
}
