/*

* Author: David Apple

* Class name: CornDodgers.cs

* Purpose: The side class that inherits from side to implement CornDodgers

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {
        /// <summary>
        /// The price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// The amount of calories in the corn dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The override method to display the actual name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Corn Dodgers";
        }
    }
}
