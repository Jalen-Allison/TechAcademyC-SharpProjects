using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game  //inheriting the class "Game"
    {
        //Play method
        public override void Play() // override allows you to implement Play since Game is abstract, tells computer we will define this method  
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
