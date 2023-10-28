using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Providers;

namespace Entities.Models.Ubications
{
    public class Municipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MunicipalityID { get; set; }

        /* Se eliminaron las data annotations */
        public string? Name { get; set; }

        /* Se eliminaron 3 propiedades: CreationDate, ModificationDate y Capital*/

        /* Se eliminó el constructor */

        //Relaciones con otros modelos

        //Department

        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }

        //Neighborhood

        public ICollection<Neighborhood> Neighborhoods { get; set; }

        public ProviderAddress? ProviderAddress { get; set; }
    }
}
