using System;
using System.Collections.Generic;
using System.Linq;

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
                isleId = Guid.NewGuid(),
                foodlist = new List<FoodItem>{
                    new FoodItem
                    {
                        foodName = "Apple",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 5
                    },
                    new FoodItem
                    {
                        foodName = "Avacado",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 13
                    },
                    new FoodItem
                    {
                        foodName = "Banana",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 8
                    },
                    new FoodItem
                    {
                        foodName = "Oranges",
                        foodType = "Fruit",
                        foodDescription = "Fruit",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 4
                    }
                },
            },
            new GroceryIsle
            {
                isleName = "Dairy",
                isleNum = 10,
                isleId = Guid.NewGuid(),
                foodlist = new List<FoodItem>{
                    new FoodItem
                    {
                        foodName = "Whole Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 15
                    },
                    new FoodItem
                    {
                        foodName = "Chocolate Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 3
                    },
                    new FoodItem
                    {
                        foodName = "Skim Milk",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 2
                    },
                    new FoodItem
                    {
                        foodName = "Cheese",
                        foodType = "dairy",
                        foodDescription = "dairy",
                        foodId = Guid.NewGuid(),
                        foodQuantity = 12
                    }
                }
            }
        };

        public GroceryIsle GetIsle(Guid isleID)
        {
            return groceryIsles.SingleOrDefault(isl => isl.isleId == isleID);
        }

        public FoodItem GetFoodItem(Guid isleID, Guid foodID)
        {
            var getFoodIsle = GetIsle(isleID);
            return getFoodIsle.foodlist.SingleOrDefault(food => food.foodId == foodID);
        }

        public List<GroceryIsle> GetGroceryIsles()
        {
            return groceryIsles;
        }

        public void UpdateFoodQuantitye(Guid isleID, Guid FoodID, bool isIncrement)
        {
            var foodItm = GetFoodItem(isleID, FoodID);
            if(isIncrement == true && foodItm.foodQuantity < 20)
            {
                foodItm.foodQuantity++;
            }

            if(isIncrement == false && foodItm.foodQuantity > 0)
            {
                foodItm.foodQuantity--;
            }
        }

        public void AddFoodItemToIsle(Guid isleID, string foodName)
        {
            var foodID = Guid.NewGuid();

            var groceryIsleToAddFoodTo = GetIsle(isleID);
            groceryIsleToAddFoodTo.foodlist.Add(
                new FoodItem
                {
                    foodName = foodName,
                    foodType = groceryIsleToAddFoodTo.isleName,
                    foodDescription = groceryIsleToAddFoodTo.isleName,
                    foodId = foodID,
                    foodQuantity = 0
                }
            );
        }
    }
}
