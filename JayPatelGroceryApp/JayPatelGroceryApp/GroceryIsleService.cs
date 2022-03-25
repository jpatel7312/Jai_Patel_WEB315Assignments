using System.Collections.Generic;

namespace JayPatelGroceryApp
{
    public class GroceryIsleService : IGroceryIsleService
    {
        private List<GroceryIsle> groceryIsles = new List<GroceryIsle>
        {
            new GroceryIsle
            {
                isleName = "Fruits",
                isleNum = 1,
                foodlist = new List<FoodItem>{
                    new FoodItem
                    {
                        foodName = "Apple",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodQuantity = 5
                    },
                    new FoodItem
                    {
                        foodName = "Avacado",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodQuantity = 13
                    },
                    new FoodItem
                    {
                        foodName = "Banana",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodQuantity = 8
                    },
                    new FoodItem
                    {
                        foodName = "Oranges",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodQuantity = 4
                    }
                },
            },
            new GroceryIsle
            {
                isleName = "Dairy",
                isleNum = 10,
                foodlist = new List<FoodItem>{
                    new FoodItem
                    {
                        foodName = "Whole Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodQuantity = 15
                    },
                    new FoodItem
                    {
                        foodName = "Chocolate Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodQuantity = 3
                    },
                    new FoodItem
                    {
                        foodName = "Skim Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodQuantity = 2
                    },
                    new FoodItem
                    {
                        foodName = "Cheese",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodQuantity = 12
                    }
                }
            }
        };
        public List<GroceryIsle> GetGroceryIsles()
        {
            return groceryIsles;
        }
    }
}
