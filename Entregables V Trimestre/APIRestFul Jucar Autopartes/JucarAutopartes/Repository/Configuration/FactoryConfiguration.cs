using Entities.Models.Factories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class FactoryConfiguration : IEntityTypeConfiguration<Factory>
    {
        public void Configure(EntityTypeBuilder<Factory> builder)
        {
            builder.HasData
                (
                new Factory
                {
                    FactoryID = new Guid("DD84045C-100B-43D9-BD79-F9E174511AFF"),
                    NIT = "1345432",
                    BusinessName = "JucarAutopartes",
                    EmailAddress = "Danieladmin@jucar.com",


                },

                 new Factory
                 {
                     FactoryID = new Guid("4667F93E-75A9-4935-87ED-3A73E638046F"),
                     NIT = "1345432",
                     BusinessName = "Adiautos",
                     EmailAddress = "Cristianadmin@jucar.com",
                 },

                  new Factory
                  {
                      FactoryID = new Guid("22EE0460-57B4-4AB6-A060-710073D1CAB3"),
                      NIT = "1345432",
                      BusinessName = "JucarAutopartes",
                      EmailAddress = "Migueladmin@jucar.com",

                  }

                );
        }
    }
}
