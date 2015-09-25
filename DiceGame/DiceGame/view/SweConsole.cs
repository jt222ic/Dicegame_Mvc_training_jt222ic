using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.view
{
    class SweConsole : Console
    {

        override public void DisplayInstruction()
        {
            System.Console.Clear();
            string message = "Välkommen till tärningspelet. Tryck en tangent för att spela, eller s för att sluta";
            System.Console.WriteLine(message);
        }

        public override bool WantsToPlay()
        {
            return System.Console.ReadKey().KeyChar != 's';      /// override wants to let play om tangentknappen är inte S
        }

         override public void DisplayResult(bool a_iswinner)                // override texten om du är vinnare eller inte 
        {


             if(a_iswinner)
             {
                 System.Console.WriteLine("du är en vinnare!");
             }
             else
             {
                 System.Console.WriteLine("Ledsen men du förlorade!");
             }

        }
    }
}
