using System;

namespace Open_Closed
{
    //Software entities such as modules, classes, functions, etc. should be open for extension, but closed for modification

    //In this program we can see that if we add another color in NotOC, we need to modify the main method (GetProductPrice)
    //And in the OC we only add another method without modifying the main one and overriding that one

    public class DemoOC
    {
        static void Main(string[] args)
        {
            ProductOC RedProduct = new RedProduct();
            ProductOC BlueProduct = new BlueProduct();
            ProductOC YellowProduct = new YellowProduct();

            double RedProductAmount = RedProduct.GetProductPrice(100);
            double BlueProductAmount = BlueProduct.GetProductPrice(100);
            double YellowProductAmount = YellowProduct.GetProductPrice(100);

            Console.ReadKey();
        }
    }
}
