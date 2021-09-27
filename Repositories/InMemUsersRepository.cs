using System;
using System.Linq;
using System.Collections.Generic;
using Orderplacement_system.Models;

namespace Orderplacement_system.Repositories
{
    public class InMemUsersRepository : IInMemUsersRepository
    {
        // readonly because it should not change after we have created the repository object.
        private readonly List<User> Users = new()
        {
            new User
            {
                Id = Guid.NewGuid(),
                Name = "John Test",
                Email = "John.Test@gmail.com",
                Phone = "999 99 999",
                City = "Testing",
                Street = "Testroad 43",
                ZipCode = "1000"
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Pingu",
                Email = "pingu@gmail.com",
                Phone = "666 66 666",
                City = "North pole",
                Street = "Deathvaley 25",
                ZipCode = "20131"
            }
        };

        public IEnumerable<User> GetUsers()
        {
            return Users;
        }

        public User GetUser(Guid id)
        {
            // Where imported from System.Linq;
            // Lambda expression extracts users from the list checks if user exist and returns the list of users found.
            // .SingleOrDefault() return User or NULL if user does not exist in List<User>.
            return Users.Where(User => User.Id == id).SingleOrDefault();
        }

        public void CreateUser(User user)
        {
            Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var index = Users.FindIndex(existingItem => existingItem.Id == user.Id);
            Users[index] = user;
        }

        public void DeleteUser(Guid id)
        {
            var index = Users.FindIndex(existingItem => existingItem.Id == id);
            Users.RemoveAt(index);
        }
    }
}
