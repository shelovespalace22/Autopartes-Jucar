using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Ubications.Municipality
{
    public record MunicipalityDto
    {
        public Guid MunicipalityID { get; init; }
        public string? Name { get; init; }
    }
}
