using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GroceryList;   // we have to initialize it before use
        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };

        }
        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and there are: " + GroceryList.ToString(); 
        }
    }
}
