using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtapi.Models
{
    public class user
    {
        public int Id { get; set; }

        public string? Firstname { get; set; }

        public string? LastName { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }

        public string? Token { get; set; }

        public string? Role { get; set; }
        public string? Email { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}