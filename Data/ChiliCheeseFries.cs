﻿/*

* Author: David Apple

* Class name: ChiliCheeseFries.cs

* Purpose: The side class that implements ChiliCheeseFries and its properties

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// the price of the chili cheese fries
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small)
                    return 1.99;
                else if (this.Size == Size.Medium)
                    return 2.99;
                else
                    return 3.99;
            }
        }

        /// <summary>
        /// the amount of calories in small medium or large fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small)
                    return 433;
                else if (this.Size == Size.Medium)
                    return 524;
                else
                    return 610;
            }
        }

        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }

    }
}
