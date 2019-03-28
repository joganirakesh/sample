using KLO.Data.Infrastructure;
using KLO.Data.Repositories;
using KLO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLO.Service
{
    // operations you want to expose
    public interface IUserService
    {
        IEnumerable<User> GetUsers(string name = null);
        User GetUserById(int id);
        void CreateUser(User user);
        void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        void IUserService.CreateUser(User user)
        {
            userRepository.Add(user);
        }

        User IUserService.GetUserById(int id)
        {
            var user = userRepository.GetById(id);
            return user;
        }

        IEnumerable<User> IUserService.GetUsers(string username)
        {
            if (string.IsNullOrEmpty(username))
                return this.userRepository.GetAll();
            else
                return this.userRepository.GetAll().Where(c => c.Username == username);
        }

        void IUserService.SaveUser()
        {
            unitOfWork.Commit();
        }
    }
}
