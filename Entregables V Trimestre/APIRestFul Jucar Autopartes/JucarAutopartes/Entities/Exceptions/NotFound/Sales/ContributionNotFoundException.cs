using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class ContributionNotFoundException : NotFoundException
    {
        public ContributionNotFoundException(Guid contributionId)
            :base($"The Contribution with ID: {contributionId} doesn´t exist in the database.")
        {
            
        }
    }
}
