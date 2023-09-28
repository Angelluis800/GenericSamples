using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples
{
    public enum MyColors
    {
        Red = 1, Green, Blue
    };
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }

        public MyColors Color { get; set; }

        //Clase para imprimir lo que yo quiera en el metodo generico segun esta clase libro
        public override string ToString()  //OVERRIDE
        {
            return $"ID:{ID}, Name:{Name}, ISBN({ISBN})";
        }
    }

}
