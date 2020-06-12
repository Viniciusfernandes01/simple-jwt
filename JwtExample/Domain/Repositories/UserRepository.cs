using JwtExample.Domain.Core.Enums;
using JwtExample.Domain.Models;
using JwtExample.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace JwtExample.Domain.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(
                new User { Id = 1, Username = "batman", Password = "batman", Role = UserRole.Manager.GetDescriptionString()});
            users.Add(
                new User { Id = 2, Username = "robin", Password = "robin", Role = UserRole.Employee.GetDescriptionString()});
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
