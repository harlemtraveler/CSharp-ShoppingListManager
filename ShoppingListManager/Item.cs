using System;

namespace ShoppingListManager
{
    public class Item
    {
        public string Name;
        public DateTime DateAdded;

        public enum Priority
        {
            Low, 
            Medium, 
            High
        }

        public enum Category
        {
            Food,
            Clothing
        };
        public Nullable<DateTime> DatePurchased;
        
        public Item() {}
        // public Item(string name, )
        
    }
}