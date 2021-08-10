using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class Client
    {
        public Client(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
