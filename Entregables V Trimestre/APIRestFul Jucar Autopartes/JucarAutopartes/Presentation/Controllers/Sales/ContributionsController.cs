using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using Shared.DataTransferObjects.Sales.Contribution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/orders/{orderId}/contributions")]
    [ApiController]
    public class ContributionsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ContributionsController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public async Task<IActionResult> CreateContribution(Guid orderId, [FromBody] ContributionForCreationDto contribution)
        {
            if (contribution is null)
                return BadRequest("ContributionForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var contributionToReturn = await _service.ContributionService.CreateContributionAsync(orderId, contribution, trackChanges: false);

            return CreatedAtRoute("GetContributionForOrder", new { orderId, id = contributionToReturn.ContributionID }, contributionToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteContribution(Guid orderId, Guid id)
        {
            await _service.ContributionService.DeleteContributionAsync(orderId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetContributions(Guid orderId)
        {
            var contributions = await _service.ContributionService.GetContributionsAsync(orderId, trackChanges: false);

            return Ok(contributions);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetContributionForOrder")]
        public async Task<IActionResult> GetContribution(Guid orderId, Guid id)
        {
            var contribution = await _service.ContributionService.GetContributionAsync(orderId, id, trackChanges: false);

            return Ok(contribution);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateContribution(Guid orderId, Guid id, [FromBody] ContributionForUpdateDto contributionForUpdate)
        {
            if (contributionForUpdate is null)
                return BadRequest("ContributionForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.ContributionService.UpdateContributionAsync(orderId, id, contributionForUpdate, ordTrackChanges: false, conTrackChanges: true);

            return NoContent();
        }
    }
}
