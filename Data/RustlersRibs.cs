/*

* Author: David Apple

* Class name: RustlersRibs.cs

* Purpose: The class with the properties of the Rustlers Ribs

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// the price of the ribs
        /// </summary>
        public override double Price
        {
            get => 7.50;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public override uint Calories
        {
            get => 894;
        }

         /// <summary>
         /// The list of special instructions to make 
         /// Rustler ribs
         /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
               
                return instructions;
            }
        }
    }
}
