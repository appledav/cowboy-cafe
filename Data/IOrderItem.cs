using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {

        /// <summary>
        /// the price of the item 
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The list of instructions to make our order
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
