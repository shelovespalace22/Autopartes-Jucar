using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record CategoryDto
    {
        public Guid CategoryId { get; init; }
        public string? Name { get; init; }
        public bool State { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
    }
}
