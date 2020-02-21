/*

* Author: David Apple

* Class name: TexasTea.cs

* Purpose: The drink class that implements Texas Tea

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// Sweet tea or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Does the customer want lemon in their tea
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Price of the Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// the amount of calories in the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                // if the tea is sweet
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 10;
                        case (Size.Medium):
                            return 22;
                        case (Size.Large):
                            return 36;
                        default:
                            throw new NotImplementedException();

                    }
                }
                else
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 5;
                        case (Size.Medium):
                            return 11;
                        case (Size.Large):
                            return 18;
                        default:
                            throw new NotImplementedException();

                    }
                }
                
            }
        }

        /// <summary>
        /// The list of special instructions to make the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
                return Size + " Sweet Texas Tea";
            else
                return Size + " Unsweet Texas Tea";
        }
    }
}
