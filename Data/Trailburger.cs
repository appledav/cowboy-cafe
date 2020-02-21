/*

* Author: David Apple

* Class name: Trailburger.cs

* Purpose: The class to describe the trailburgers properties

*/



using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger: Entree
    {
        /// <summary>
        /// the price of the trailburger
        /// </summary>
        public override double Price
        {
            get => 4.50;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public override uint Calories
        {
            get => 288;
        }

        /// <summary>
        /// does the customer want ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// does the customer want mustard
        /// </summary>
        public bool Mustard { get; set; } = true;


        /// <summary>
        /// does the customer want pickles
        /// </summary>
        public bool Pickle { get; set; } = true;


        /// <summary>
        /// is there cheese on the sandwich
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// is the bun included
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// The list of special instructions on how to make the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Bun) instructions.Add("hold bun");

                return instructions; 
            }
        }


        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }

    }
}
