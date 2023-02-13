using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public class UserResposity : IUserResposity
    {
        private readonly DataContext _context;
        public UserResposity(DataContext context)
        {
            _context = context;
        }

        public List<UserModel> GetAll(string search)
        {
            var allUsers=_context.Users.Where(x=>x.UserName.Contains(search));
            var result = allUsers.Select(x=> new UserModel{
                UserName=x.UserName,
                Password=x.Password,
                PasswordSalt=x.PasswordSalt
            });
            return result.ToList();
        }
    }
}