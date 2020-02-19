/*

* Author: David Apple

* Class name: Water.cs

* Purpose: The drink class that implements Water 

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        public bool Lemon { get; set; }

        /// <summary>
        /// The price of water
        /// </summary>
        public override double Price
        {
            get => .12;
        }

        
        /// <summary>
        /// The amount of calories in water
        /// </summary>
        public override uint Calories
        {
            get => 0;
        }


        /// <summary>
        /// The special instructions for water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }


        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Water";
        }



    }
}
