using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayPatelGroceryApp
{
    public class GroceryIsle
    {
        //public FoodItem FoodItem { get;set; }
        public string isleName { get; set; }
        public int isleNum { get; set; }

        public Guid isleId { get; set; }
        public List<FoodItem> foodlist{ get; set; }


    }
}
