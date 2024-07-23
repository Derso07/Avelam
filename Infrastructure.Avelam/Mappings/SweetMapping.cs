using ApplicationCore.Avelam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Avelam.Mappings
{
    public class SweetMapping : IEntityTypeConfiguration<Sweet>
    {
        public void Configure(EntityTypeBuilder<Sweet> builder)
        {
            builder.ToTable("sweet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(x => x.TypeSweet)
                .IsRequired()
                .HasColumnType("int");

        }
    }
}
