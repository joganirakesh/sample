using KLO.Model;
using System.Data.Entity.ModelConfiguration;

namespace KLO.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            Property(u => u.Username).IsRequired().HasMaxLength(100);
            Property(u => u.Email).IsRequired().HasMaxLength(200);
            Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            Property(u => u.Salt).IsRequired().HasMaxLength(200);
        }
    }
}
