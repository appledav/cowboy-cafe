using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Trailburger
    {
        /// <summary>
        /// the price of the trailburger
        /// </summary>
        public double Price
        {
            get => 4.50;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public uint Calories
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
        /// is the bun includede 
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// The list of special instructions on how to make the burger
        /// </summary>
        public List<string> SpecialInstructions
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

    }
}
