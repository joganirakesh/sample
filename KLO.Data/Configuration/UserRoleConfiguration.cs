using System.Data.Entity.ModelConfiguration;
using KLO.Model;

namespace KLO.Data.Configuration
{
    public class UserRoleConfiguration:EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            ToTable("UserRole");
            Property(usr => usr.UserId).IsRequired();
            Property(usr => usr.RoleId).IsRequired();
        }
    }
}
