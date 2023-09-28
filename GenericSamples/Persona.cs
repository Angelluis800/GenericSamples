using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenericSamples
{
    public class Persona
    {
        public string Name { get; set; }
        public int age { get; set; }
        public int ID { get; set; } 
        public string PhoneNumber { get; set; }

        public override string ToString()  //OVERRIDE
        {
            return $"{ID} {Name} ({PhoneNumber} {age})";
        }
    }
}
