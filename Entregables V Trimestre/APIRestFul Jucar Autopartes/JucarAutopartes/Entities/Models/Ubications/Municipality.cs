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
    public class Municipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MunicipalityID { get; set; }
        public string? Name { get; set; }

        //Department

        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }

        //Neighborhood

        public ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
