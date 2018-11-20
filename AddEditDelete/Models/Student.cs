using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddEditDelete.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long  Phone { get; set; }
        public DateTime BirtDay { get; set; }
    }
}
