using KLO.Model;
using KLO.Data.Configuration;
using System.Data.Entity;


namespace KLO.Data
{
    public class KLOEntities : DbContext
    {
        public KLOEntities() : base("KLOEntities") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
        }
    }
}
