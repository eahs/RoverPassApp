using System;
using System.Collections.Generic;
using System.Text;

namespace RoverPass.Models
{
    class AuthenticateResponse
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
