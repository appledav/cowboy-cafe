/*

* Author: David Apple

* Class name: Entree.cs

* Purpose: The base class to be inherited from

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// the price of the entree
        /// </summary>
        public abstract double Price { get; }
            
        /// <summary>
        /// how many calories are in the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions list for each entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
