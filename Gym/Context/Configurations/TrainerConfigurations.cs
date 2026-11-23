using Microsoft.EntityFrameworkCore;
using Gym.Entities;
namespace Gym.Context.Configurations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.CreatedAt).
                HasColumnName("HireDate").
                HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
