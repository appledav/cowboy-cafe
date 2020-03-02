using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// the order number to be stored
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// A way of storing what order number we are on
        /// </summary>
        public uint OrderNumber;

        /// <summary>
        /// Constructor to update order Number 
        /// </summary>
        public Order()
        {
            OrderNumber = lastOrderNumber++;
        }

        /// <summary>
        /// The event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the list of items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The list of Items in our order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// removing an item from our order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
