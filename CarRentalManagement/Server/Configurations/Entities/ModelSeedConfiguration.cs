using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
  public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
  {
    public void Configure(EntityTypeBuilder<Model> builder)
    {
      builder.HasData(
        new Model
        {
          Id = 1,
          CreatedDate = DateTime.Now,
          CreatedBy = "System",
          Name = "Vitz",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        },
        new Model
        {
          Id = 2,
          CreatedDate = DateTime.Now,
          CreatedBy = "System",
          Name = "3 Series",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        },
        new Model
        {
          Id = 3,
          CreatedDate = DateTime.Now,
          CreatedBy = "System",
          Name = "X4",
          UpdateDate = DateTime.Now,
          UpdatedBy = "System"
        }
      );
    }
  }
}