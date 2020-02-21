/*

* Author: David Apple

* Class name: JerkedSoda.cs

* Purpose: The class that inherits from Drink to implement Jerked Soda

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of the jerked soda for each size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// the amount of calories for each size of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 146;
                    case (Size.Large):
                        return 198;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        

        /// <summary>
        /// The list of instructions as to how to make the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// The enum to display each flavor of soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }


        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";
                default:
                    return Size + " Birch Beer Jerked Soda";

            }
        }
    }
}
