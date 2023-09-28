using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples
{
    public class Conjunto<CualquierCosa>
    {
        private CualquierCosa[] _data;
        private int _amount;
        public Conjunto(int SIZE)
        {
            _data = new CualquierCosa[SIZE];
            _amount = 0;
        }

        public void ADD(CualquierCosa element)
        {
            _data[_amount++] = element;
        }

        public CualquierCosa DROP()
        {
            if (_amount > 0)
            {
                CualquierCosa removed = _data[--_amount];
                Console.WriteLine($"Element Deleted: {removed}");
                _data[_amount] = default(CualquierCosa); // Asigna el valor por defecto para eliminar el elemento.
                return removed;
            }
            else
            {
                Console.WriteLine("Its avoid cannot drop a element");
                return default(CualquierCosa);
            }

        }

        public void Print()
        {
            for(int i = 0; i < _amount; i++)
            {
                Console.WriteLine($"Elements {i+1}: { _data[i]}");
            }
        }
    }

    
}
