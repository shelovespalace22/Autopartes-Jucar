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
        public IActionResult CreateContribution(Guid orderId, [FromBody] ContributionForCreationDto contribution)
        {
            if (contribution is null)
                return BadRequest("ContributionForCreationDto object is null");

            var contributionToReturn = _service.ContributionService.CreateContribution(orderId, contribution, trackChanges: false);

            return CreatedAtRoute("GetContributionForOrder", new { orderId, id = contributionToReturn.ContributionID }, contributionToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteContribution(Guid orderId, Guid id)
        {
            _service.ContributionService.DeleteContribution(orderId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetContributions(Guid orderId)
        {
            var contributions = _service.ContributionService.GetContributions(orderId, trackChanges: false);

            return Ok(contributions);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetContributionForOrder")]
        public IActionResult GetContribution(Guid orderId, Guid id)
        {
            var contribution = _service.ContributionService.GetContribution(orderId, id, trackChanges: false);

            return Ok(contribution);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateContribution(Guid orderId, Guid id, [FromBody] ContributionForUpdateDto contributionForUpdate)
        {
            if (contributionForUpdate is null)
                return BadRequest("ContributionForUpdateDto object is null");

            _service.ContributionService.UpdateContribution(orderId, id, contributionForUpdate, ordTrackChanges: false, conTrackChanges: true);

            return NoContent();
        }
    }
}
