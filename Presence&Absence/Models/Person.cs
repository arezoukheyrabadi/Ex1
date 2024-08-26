using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presence_Absence.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public bool Absence { get; set; }


    }
}
