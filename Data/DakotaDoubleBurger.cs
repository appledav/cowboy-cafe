using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// the price of the Dakota Double
        /// </summary>
        public double Price
        {
            get => 5.20;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public uint Calories
        {
            get => 464;
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
        /// if tomato is included
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Is lettuce on the burger?
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Does the customer want mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

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
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");


                return instructions;
            }
        }
    }
}
