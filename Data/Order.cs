using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order  
    {

        /// <summary>
        /// the order number to be stored
        /// </summary>
        private uint lastOrderNumber;

        /// <summary>
        /// the list of items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The list of Items in our order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items;

        /// <summary>
        /// The total cost of our order
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double total = 0;
                foreach (var item in items)
                {
                    total += item.Price;
                }
                return total;
            }        
        }


        /// <summary>
        /// Adding an item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            
        }

        /// <summary>
        /// removing an item from our order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
        }
    }
}
