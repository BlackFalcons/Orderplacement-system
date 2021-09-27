using Orderplacement_system.Models;
using System;
using System.Collections.Generic;

namespace Orderplacement_system.Repositories
{
    public interface IInMemUsersRepository
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}