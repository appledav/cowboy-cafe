using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// the price of the ribs
        /// </summary>
        public double Price
        {
            get => 7.50;
        }

        /// <summary>
        /// the number of calories
        /// </summary>
        public uint Calories
        {
            get => 894;
        }

         /// <summary>
         /// The list of special instructions to make 
         /// Rustler ribs
         /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
               
                return instructions;
            }
        }
    }
}
