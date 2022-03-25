using System;
using System.Collections.Generic;

namespace JayPatelGroceryApp
{
    public interface IGroceryIsleService
    {
        List<GroceryIsle> GetGroceryIsles();

        GroceryIsle GetIsle(Guid isleID);

        FoodItem GetFoodItem(Guid isleID, Guid foodID);

        void UpdateFoodQuantitye(Guid isleID, Guid foodID, bool isIncrement);

        void AddFoodItemToIsle(Guid isleID, string foodID);

    }
}
