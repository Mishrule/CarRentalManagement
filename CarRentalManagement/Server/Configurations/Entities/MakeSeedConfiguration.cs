using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
  public class MakeSeedConfiguration: IEntityTypeConfiguration<Make>
  {
    public void Configure(EntityTypeBuilder<Make> builder)
    {
      builder.HasData(
        new Make
        {
          Id = 1,
          CreatedDate = DateTime.Now,
          Name = "BMW",
          CreatedBy = "System",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        },
        new Make
        {Id = 2,
          CreatedDate = DateTime.Now,
          Name = "Ford",
          CreatedBy = "System",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        },
        new Make
        {Id = 3,
          CreatedDate = DateTime.Now,
          Name = "Toyota",
          CreatedBy = "System",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        }
        );
    }
  }
}
