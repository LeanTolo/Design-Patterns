using System;
//Liskov Substitution
//"You should be able to replace a base-type for a sub-type"
namespace Liskov_Substitution_EN
{
    
    class Program
    {
        static public int Area(RectangleWrong r) => r.Width * r.Height;
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Console.WriteLine("Using RectangleWrong");
            RectangleWrong rc = new(2,3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Console.WriteLine("Using SquareWrong");
            SquareWrong square = new SquareWrong();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}"); //Output: Width: 4, Height: 4 has area 16

            //It's working ok, but what happens when we upcast this to a Rectangle class
            Console.WriteLine("Upcasting SquareWrong to RectangleWrong (using new int in properties)");
            RectangleWrong square2 = new SquareWrong();
            square2.Width = 4;
            Console.WriteLine($"{square2} has area {Area(square2)}"); //Output: Width: 4, Height: 0 has area 0
            //What happened ? So when it's upcasted, it's not looking to the square Height property 

            //Let's use the Virtual keyword on the rectangle properties
            Console.WriteLine("Using Square");
            Square square3 = new();
            square3.Width = 5;
            Console.WriteLine($"{square3} has area {Area(square3)}"); //Output: Width: 5, Height: 5 has area 25

            //Now it's working propperly since we used correctly the liskov substitution principle, provided via the 'virtual' and 'override' keywords
            Console.WriteLine("Upcasting Square to Rectangle (using override in properties)");
            Rectangle square4 = new Square();
            square4.Width = 5;
            Console.WriteLine($"{square4} has area {Area(square4)}"); //Output: Width: 5, Height: 5 has area 25

            Console.WriteLine("I understand the Liskov Substitution Principle now ! :D");
        }
    }
}
