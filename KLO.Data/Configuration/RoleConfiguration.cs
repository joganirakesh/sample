using KLO.Model;
using System.Data.Entity.ModelConfiguration;

namespace KLO.Data.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Role");
            Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
