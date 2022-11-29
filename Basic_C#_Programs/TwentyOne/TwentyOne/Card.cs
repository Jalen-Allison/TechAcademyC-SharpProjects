using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card // just a design doesnt give it value. Need to make an onject that is modeled after this class
    {
        public Card() // constructor = values assigned to an object upon creation. Constructor method name is same as class
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //public = accessable to other parts of the program
        public string Face { get; set; }
    }
}
