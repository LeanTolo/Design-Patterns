using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    //Software entities such as modules, classes, functions, etc. should be open for extension, but closed for modification
    //In this case we have a base method that all the colors interact with him
    //We override the main method and we are not modifying the main method so it respect the Open Close Principle
    public class ProductOC
    {
        public virtual double GetProductPrice(double amount)
        {
            return (amount * 1.21);//IVA
        }
    }
    public class RedProduct : ProductOC
    {
        public override double GetProductPrice(double amount)
        {
            return base.GetProductPrice(amount) * 1.3;
        }
    }
    public class BlueProduct : ProductOC
    {
        public override double GetProductPrice(double amount)
        {
            return base.GetProductPrice(amount) * 1.4;
        }
    }
    public class YellowProduct : ProductOC
    {
        public override double GetProductPrice(double amount)
        {
            return base.GetProductPrice(amount) * 1.5;
        }
    }
}
