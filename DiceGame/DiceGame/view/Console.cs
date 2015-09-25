using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.view
{
    abstract class Console
    {

        abstract public void DisplayInstruction();

        public void DisplayDiceValue(int a_faceValue)                // han har console klass för att kunna läsa av knappar vilket tycker jag är onödigt att ha i en seperat klass
        {
            System.Console.WriteLine("{0}", a_faceValue);
        }

        abstract public bool WantsToPlay();

        public char GetInput()                                 // returneras inmatningar 
        {
            return System.Console.ReadKey().KeyChar;
        }

        abstract public void DisplayResult(bool a_isWinner);
        
        
        
                                                    // abstract för att inheritence klasser kan override
    }
}
