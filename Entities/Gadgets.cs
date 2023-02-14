using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public class Gadgets
    {
        //public string Id { get; set; }
        public string ProductName { get; set; }
        public string Uniqueness { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{this.ProductName}\t{this.Uniqueness}\t{this.Price}";
        }
        public Gadgets ToObj2(string str)
        {
            var type = str.Split("\t");
            var obj = new Gadgets
            {
                ProductName = type[0],
                Uniqueness = type[1],
                Price = int.Parse(type[2]),
            };
            return obj;
        }
    }

    
}