using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Ubications
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DepartmentID { get; set; }

        /* Se eliminó los DataAnnotations */
        public string? Name { get; set; }

        /* Se eliminaron 3 propiedades: CreationDate, ModificationDate y Capital*/

        /* Se eliminó el constructor */

        //Relaciones con otros modelos 

        public ICollection<Municipality> Municipalities { get; set; }

    }
}
