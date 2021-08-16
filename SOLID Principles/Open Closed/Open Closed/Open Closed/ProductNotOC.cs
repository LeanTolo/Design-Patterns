using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    //Software entities such as modules, classes, functions, etc. should be open for extension, but closed for modification
    //In this case we have different types of colors but we are working with our method GetProductPrice
    //In case we add another color into enum, we need to change our method adding a part to select the new color with the new product
    public class ProductNotOC
    {
        public double GetProductPrice(double amount, Color color) 
        {
            double total = 0;
            if (color == Color.Red)
            {
                total = amount * 1.3;
            }
            else
            {
                if (color == Color.Blue)
                {
                    total = amount * 1.4;
                }
                else
                {
                    if (color == Color.Yellow)
                    {
                        total = amount * 1.5;
                    }
                }
            }
            return (total * 1.21);//IVA
        }
    }

    public enum Color
    {
        Red,
        Blue,
        Yellow
    };
}
