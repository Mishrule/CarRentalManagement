using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
  public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
  {
    public void Configure(EntityTypeBuilder<Colour> builder)
    {
      builder.HasData(
        new Colour
        {
          Id = 1,
          CreatedBy = "System",
          CreatedDate = DateTime.Now,
          Name = "Black",
          UpdatedBy = "System"
        },
        new Colour
        {
          Id = 2,
          CreatedBy = "System",
          CreatedDate = DateTime.Now,
          Name = "Blue",
          UpdatedBy = "System"
        }

      );
    }
  }
}
