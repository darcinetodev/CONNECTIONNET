using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONNECTION.Models
{
    public class Peoples
    {
        public Peoples()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
    }
}
