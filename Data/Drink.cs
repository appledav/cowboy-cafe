/*

* Author: David Apple

* Class name: Drink.cs

* Purpose: The base class that all drinks derive from

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The amount of calories in a drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The list of instructions for each drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// The size of a drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Is there ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

    }
}
