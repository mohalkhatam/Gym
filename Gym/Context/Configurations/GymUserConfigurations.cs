using Microsoft.EntityFrameworkCore;

using Gym.Entities;
namespace Gym.Context.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);
            builder.Property(x => x.Phone)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);
            builder.Property(X => X.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);
            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(X => X.Email).IsUnique();
            builder.HasIndex(X => X.Phone).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email LIKE '%@%.com'");
                T.HasCheckConstraint("\"GymUser_PhoneCheck", "LEN(Phone) = 11 AND Phone Like '010%' or Phone Like '011%' or Phone Like '012%' or Phone Like '015%'");
            });
        }
    }
}
