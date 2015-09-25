using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.model
{
    class DiceGame
    {
        Dice m_d1;                                       // kastar 3 dices
        Dice m_d2;
        Dice m_d3;


        List<DiceGameObserver> m_observers;


        public DiceGame()
        {
            m_d1 = new Dice();                                               // 3 olika tärningar instansieras från Dice klassen, 
            m_d2 = new Dice();
            m_d3 = new Dice();
            m_observers = new List<DiceGameObserver>();                                    // en lista av Dice Game observer


        }
        public void AddSubscriber(DiceGameObserver a_sub)              
        {
            m_observers.Add(a_sub);

        }
        private void RollDice(Dice a_dice)
        {
            a_dice.Roll();                                                          // rolla tärningen och får värdet
            foreach (DiceGameObserver o in m_observers)
            {
                o.DiceRolled(a_dice.GetValue());

            }
        }

        public bool Play()                                                        // tiden mellan kastningar 
        {
            RollDice(m_d1);
            System.Threading.Thread.Sleep(2000);                                // roll the dice from dice class with m_d3, m_d2 , m_d1
            RollDice(m_d2);
            System.Threading.Thread.Sleep(2000);
            RollDice(m_d3);
             
            return m_d1.GetValue() + m_d2.GetValue() + m_d3.GetValue() == 9;                      // om värdet returneras 9 vinnar man om över förlorar man 
        }
    }
}
