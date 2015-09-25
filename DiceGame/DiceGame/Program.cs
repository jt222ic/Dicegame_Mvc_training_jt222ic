using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {

        static void Main(string[] args)                                             // entry points, startpunkt för att instansiera de olika klasserna 
        {                                                                           // kom ihåg att stava static void med Stort M för Main 
            model.DiceGame g = new model.DiceGame();
            view.Console v = new view.SweConsole();
            controller.Player c = new controller.Player(v);                            // controller skickar in view 
             


            c.PlayGame(g);                                                  // constroller skickar in värdet från modell för att starta spelet.
        }
    }
}
