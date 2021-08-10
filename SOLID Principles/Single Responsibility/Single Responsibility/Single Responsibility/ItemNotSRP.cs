using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class ItemNotSRP
    {
        public ItemNotSRP(Product product, int ammount)
        {
            Product = product;
            Ammount = ammount;
        }
        public Product Product { get; set; }
        public int Ammount { get; set; }
    }
}
