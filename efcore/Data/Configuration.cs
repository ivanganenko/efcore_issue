using EFCore.Models.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data
{
    public class Configuration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Models");

            builder.HasKey(model => model.Id);

            builder.Property(model => model.FirstName).IsRequired();

            builder.OwnsMany(
                typeof(Email),
                "Emails",
                e => e.ToTable("Emails"));
        }
    }
}