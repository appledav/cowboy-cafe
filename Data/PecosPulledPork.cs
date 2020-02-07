/*

* Author: David Apple

* Class name: PecosPulledPork.cs

* Purpose: The class to describe the pulled pork properties

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// the price of the sandwich
        /// </summary>
        public override double Price
        {
            get => 5.88;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public override uint Calories
        {
            get => 528;
        }

        /// <summary>
        /// If pickle will be included
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if the customer wants bread or not
        /// </summary>
        public bool Bread { get; set; } = true;


        /// <summary>
        /// the list of instructions as to what goes on the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pickle) instructions.Add("hold pickle");
                if (!Bread) instructions.Add("hold bread");
                return instructions;
            }
        }
        
    }
}
