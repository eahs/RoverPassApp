using System;
using System.Collections.Generic;
using System.Text;

namespace RoverPass.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string TeacherName { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public string ClassName { get; set; }
        public string RoomNumber { get; set; }
        public string JoinCode { get; set; }
    }
}
