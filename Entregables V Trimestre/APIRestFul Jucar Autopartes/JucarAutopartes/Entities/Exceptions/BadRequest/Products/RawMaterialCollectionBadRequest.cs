using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.BadRequest.Products
{
    public sealed class RawMaterialCollectionBadRequest : BadRequestException
    {
        public RawMaterialCollectionBadRequest()
            : base("Raw Material collection sent from a client is null.")
        {

        }
    }
}
