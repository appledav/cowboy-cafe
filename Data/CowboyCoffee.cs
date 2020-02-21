/*

* Author: David Apple

* Class name: CowboyCoffee.cs

* Purpose: The drink class that implements CowboyCofee

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// I dont think this belongs here
        /// </summary>
        public bool Ice = false;

        /// <summary>
        /// Is cream wanted on coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Is the coffee decaf or not
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// The price for each size of Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return .60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// The amount of calories in each size 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// List of instructions for how to make the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }

        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
                return Size + " Decaf Cowboy Coffee";
            else
                return Size + " Cowboy Coffee";
        }


    }
}
