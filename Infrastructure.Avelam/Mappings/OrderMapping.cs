using ApplicationCore.Avelam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Avelam.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Quantity)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(o => o.Price)
                .IsRequired()
                .HasColumnType("decimal");

            builder.Property(o => o.DataCreated)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(o => o.EndDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(o => o.StatusOrder)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne<Sweet>(s => s.Sweet)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.SweetId);
        }
    }
}
