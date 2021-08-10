using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class CartNotSRP
    {
        public CartNotSRP(string name,string surname)
        {
            Name = name;
            SurName = surname;
            Items = new List<ItemNotSRP>();
        }
        public string Name { get; set; }
        public string SurName { get; set; }

        public List<ItemNotSRP> Items { get; set; }
        public double Total()
        {
            double tot = 0;
            foreach (var item in Items)
            {
                tot += item.Ammount * item.Product.Price;
            }
            return tot;
        }
    }
}
