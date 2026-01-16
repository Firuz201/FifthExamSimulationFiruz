using FifthExamSimulationFiruz.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FifthExamSimulationFiruz.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);
        builder.Property(x => x.Price).HasPrecision(10, 2);
        builder.ToTable(opt =>
        {
            opt.HasCheckConstraint("CK_Events_Price", "[Price] > 0");
        });

        builder.HasOne(x => x.Location).WithMany(x => x.Events).HasForeignKey(x => x.LocationId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
    }
}
