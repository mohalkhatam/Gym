using Microsoft.EntityFrameworkCore;
using Gym.Entities;
namespace Gym.Context.Configurations
{
    public class MemberConfigurations : GymUserConfigurations<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("JoinDate")
                   .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
