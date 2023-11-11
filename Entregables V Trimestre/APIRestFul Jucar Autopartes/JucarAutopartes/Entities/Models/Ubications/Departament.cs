using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Providers;
using Entities.Models.Sales;

namespace Entities.Models.Ubications
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DepartmentID { get; set; }
        public string? Name { get; set; }

        //Relaciones con otros modelos 
        public ICollection<Municipality> Municipalities { get; set; }

    }
}
