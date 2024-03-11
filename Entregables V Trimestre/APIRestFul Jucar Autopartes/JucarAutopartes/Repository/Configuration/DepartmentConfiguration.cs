using Entities.Models.Ubications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData
            (
                new Department
                {
                    DepartmentID = new Guid("C5424105-77C9-4CB2-BF05-FF1DB7FA1B12"),
                    Name = "Bogotá D.C.",
                },

                new Department
                {
                    DepartmentID = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533"),
                    Name = "Cundinamarca",
                },

                new Department
                {
                    DepartmentID = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F"),
                    Name = "Antioquia",
                },

                new Department
                {
                    DepartmentID = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392"),
                    Name = "Boyacá",
                },

                new Department
                {
                    DepartmentID = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1"),
                    Name = "Bolívar",
                },

                new Department
                {
                    DepartmentID = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8"),
                    Name = "Santander",
                }
            );
        }
    }
}
