using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(Color.red),
                new Circle(Color.blue),
                new Rectangle(Color.green),
                new Arrow(Color.blue)
            };
            foreach(var shape in shapes)
            {
                shape.Draw(Console.WriteLine());
            }
            Console.ReadLine();

        }
    }
}
