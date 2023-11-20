using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Providers;
using Entities.Models.Sales;

namespace Entities.Models.Ubications
{
    public class Neighborhood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid NeighborhoodID { get; set; }

        /* Se eliminaron las data annotations */
        public string? Name { get; set; }

        /* Se eliminaron 2 propiedades: CreationDate y ModificationDate*/

        /* Se eliminó el constructor */

        //Relaciones con otros modelos

        //Municipality

        public Guid MunicipalityId { get; set; }
        public Municipality? Municipality { get; set; }

        /* Se eliminó la relación con Street  */

        public ICollection<ProviderAddress>? ProviderAddresses  { get; set; }
        public ICollection<CustomerAddress>? CustomerAddresses { get; set; }



    }
}
