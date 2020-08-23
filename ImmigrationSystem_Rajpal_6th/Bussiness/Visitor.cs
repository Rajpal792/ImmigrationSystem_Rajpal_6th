using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImmigrationSystem_Rajpal_6th.Bussiness
{
    public class Visitor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Agent Agent { get; set; }
        public Embassy Embassy { get; set; }
    }
}
