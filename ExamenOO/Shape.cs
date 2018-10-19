using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOO
{
    public enum Color
    {
        red,
        green,
        blue
    }
    public interface IShape
    {
        Color Color { get; set; }
        void Draw(Action<string> action);
    }

    public class Shape : IShape, IDisposable
    {
        public Color Color { get; set; }
        public virtual void Draw(Action<string> action) {}
        public void Dispose();
    }
    public class Rectangle : Shape
    {
        public Rectangle(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(string.Format("Esta figura es un {0} y es de color {1}", GetType().Name, Color));
        }
    }
    public class Circle : Shape
    {
        public Circle(Color color) 
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(string.Format("Esta figura es un {0} y es de color {1}", GetType().Name, Color));
        }
    }
    public class Arrow : Shape
    {
        public Arrow(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(string.Format("Esta figura es un {0} y es de color {1}", GetType().Name, Color));
        }
    }
}
