using Microsoft.EntityFrameworkCore;
using Gym.Entities;
namespace Gym.Context.Configurations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");
            builder.HasKey(E => E.Id);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("MemberShipDurationCheck", "DATEDIFF(day, StartDate, EndDate) BETWEEN 1 AND 365");
            });
        }
    }
}
