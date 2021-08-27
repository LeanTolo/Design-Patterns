using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_EN
{
    public class RectangleWrong
    {
        //Notice that the properties cannot be overrided by it's subclasses
        public int Width { get; set; }
        public int Height { get; set; }
        public RectangleWrong() { }
        public RectangleWrong(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    //Notice that we're using 'new int' since the property is not overridable
    public class SquareWrong : RectangleWrong
    {
        public new int Width
        {
            set { base.Width = base.Height = value; }
        }
        public new int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
    
    public class Rectangle
    {
        //Notice the virtual keyword, now we can override it in the subclasses
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle() { }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    //Notice that we're using 'override'
    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
