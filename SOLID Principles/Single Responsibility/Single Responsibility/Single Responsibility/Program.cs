using System;
using System.Collections.Generic;

namespace Single_Responsibility
{
    // Este principio parte de la base de que cada clase tiene una unica responsabilidad y esta responsabilidad es encapsulada dentro de la clase
    // Responsabilidad Unica = 1 clase => 1 razon para cambiar
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("testName", "testSurname");
            
            Item item1 = new Item(new Product("Burger", 300),3);
            Item item2 = new Item(new Product("Rice", 200), 4);
            Item item3 = new Item(new Product("Pizza", 100), 5);

            Cart cart = new Cart(client);
            cart.Items.Add(item1);
            cart.Items.Add(item2);
            cart.Items.Add(item3);

            Console.WriteLine("Total Price is: " + cart.Total());
            Console.ReadKey();

        }

        static void NotSRP()
        {
            ItemNotSRP item1 = new ItemNotSRP(new Product("Burger", 300), 3);
            ItemNotSRP item2 = new ItemNotSRP(new Product("Rice", 200), 4);
            ItemNotSRP item3 = new ItemNotSRP(new Product("Pizza", 100), 5);

            CartNotSRP cart = new CartNotSRP("NameNotSRP", "SurNameNotSRP");
            cart.Items.Add(item1);
            cart.Items.Add(item2);
            cart.Items.Add(item3);

            Console.WriteLine("Total Price is: " + cart.Total());

        }

        /*Como pueden observar no se observa a simple vista la diferencia pero a medida que los programas escalan, todo esto es mas notorio
         ya que lo importante del Single Responsibility Principle es la abstraccion de clases para sus unicas responsabilidades, en este ejemplo se
         ve la diferencia entre el cliente principalmente el cual en un caso es responsabilidad del carro de compras y en otro tiene su dominio por fuera de la clase
         y ademas, si observamos, el carro no SRP esta interactuando con los valores internos de la clase ItemNotSRP, por lo cual haciendo un metodo que calcule el
         subtotal, marcamos las responsabilidades de cada clase sobre si mismas.
         */
    }
}

