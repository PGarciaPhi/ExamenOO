using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOO
{
    public abstract class Foo
    {
        public string Name { get; set; }

    }
    public class Bar : Foo
    {
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    Console.WriteLine("Se ha modificado el nombre de {0} a {1}", _name, value);
                    _name = value;
                }
            }
        }
    }
}
