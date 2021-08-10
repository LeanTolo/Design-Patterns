using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class Cart
    {
        public Cart(Client client)
        {
            Client = client;
            Items = new List<Item>();
        }
        public Client Client { get; set; }
        public List<Item> Items { get; set; }
        public double Total()
        {
            double tot = 0;
            foreach(var item in Items)
            {
                tot += item.Subtotal();
            }
            return tot;
        }
    }
}
