using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt {get;set;}
    }
}