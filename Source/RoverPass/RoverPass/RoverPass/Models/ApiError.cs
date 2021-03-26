using System;
using System.Collections.Generic;
using System.Text;

namespace RoverPass.Models
{
    class ApiError
    {
        public string Key { get; set; }
        public List<string> Errors { get; set; }
    }
}
