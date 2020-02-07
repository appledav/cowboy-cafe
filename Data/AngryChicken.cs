/*

* Author: David Apple

* Class name: AngryChicken.cs

* Purpose: The class to describe the AngryChicken sandwich

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {

        private bool _pickle = true;
        private bool _bread = true;

        /// <summary>
        /// the price of the sandwich
        /// </summary>
        public override double Price
        {
            get => 5.99;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public override uint Calories
        {
            get => 190;
        }

        /// <summary>
        /// if the sandwich has pickle
        /// </summary>
        public bool Pickle
        {
            get { return _pickle; }
            set { _pickle = value; }
        }

        /// <summary>
        /// if bread is to be used
        /// </summary>
        public bool Bread
        {
            get { return _bread; }
            set { _bread = value; }
        }

        /// <summary>
        /// The list of special instructions to make 
        /// Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!_pickle) instructions.Add("hold pickle");
                if (!_bread) instructions.Add("hold bread");

                return instructions;
            }
        }
    }
}
