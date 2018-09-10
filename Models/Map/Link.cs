using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketToRide.Models.Map
{
    //Available link colors
    enum Color { Red, Green, Blue, Yellow, Black, White, Orange, Pink, Jolly, None }

    class Link
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="color">Link color, indicates which Train Cards can be used</param>
        /// <param name="length">Link Length, indicates how many train cards of the same color are needed</param>
        public Link(Color color, int length)
        {
            Color = color;
            Length = length;
            Taken = false;
        }
        public Color Color { get; set; }
        public int Length { get; set; }
        public bool Taken { get; set; } //Is the link already occupied?
    }
}
