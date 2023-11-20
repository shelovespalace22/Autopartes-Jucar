using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Products
{
    public sealed class StockNotFoundException : NotFoundException
    {
        public StockNotFoundException(Guid stockId)
            :base($"The Stock with ID: {stockId} doesn´t exist in the database.")
        {
                
        }
    }
}
