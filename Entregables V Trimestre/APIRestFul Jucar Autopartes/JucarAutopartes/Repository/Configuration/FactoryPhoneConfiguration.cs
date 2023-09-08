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
    public class FactoryPhoneConfiguration : IEntityTypeConfiguration<FactoryPhoneConfiguration>

    {
        public void Configure(EntityTypeBuilder<FactoryPhoneConfiguration> builder)
        {
            builder.HasData
                (
                    new FactoryPhone
                    {
                        FactoryPhoneID = new Guid("C6E288DB-3092-4B8E-A33D-54A0D419CA6D"),
                        PhoneType = "Celular",
                        PhoneNumber = "3115530093",
                        FactoryId = new Guid("DD84045C-100B-43D9-BD79-F9E174511AFF")
                        

                    },


                    new FactoryPhone
                    {
                        FactoryPhoneID = new Guid("A7BFB2E4-6BD1-44BB-8A62-FC7357FE8E87"),
                        PhoneType = "Celular",
                        PhoneNumber = "31342134587",
                        FactoryId = new Guid("4667F93E-75A9-4935-87ED-3A73E638046F")  
                        

                    },

                    new FactoryPhone
                    {
                        FactoryPhoneID = new Guid("8567F7A2-2BAD-409A-B1B1-176B541E15FB"),
                        PhoneType = "Celular",
                        PhoneNumber = "3124276511",
                        FactoryId = new Guid("22EE0460-57B4-4AB6-A060-710073D1CAB3")
                        

                    }
                );



        }
    }

}
