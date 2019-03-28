using KLO.Model;
using KLO.Data.Infrastructure;
using System.Linq;

namespace KLO.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByName(string userName);
    }

    public class UserRepository: RepositoryBase<User>
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
