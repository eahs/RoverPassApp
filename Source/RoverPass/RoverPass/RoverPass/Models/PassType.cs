using System;
using System.Collections.Generic;
using System.Text;

namespace RoverPass.Models
{
    public class PassType
    {
        public int PassTypeId { get; set; }
        public string Name { get; set; }
        public bool StudentCreatable { get; set; }
        public bool IsEnabled { get; set; }
    }
}
