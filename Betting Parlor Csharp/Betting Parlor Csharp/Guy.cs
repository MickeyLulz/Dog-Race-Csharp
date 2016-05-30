using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Parlor_Csharp
{
    public class Guy
    {
        public string Name { get; set; }
        private double Cash { get; set; }
        private double MyBet { get; set; }
        private int DogNum { get; set; }
        private bool betPlaced { get; set; }

        public Guy(string name, double cash)
        {
            Name = name;
            Cash = cash;
            betPlaced = false;
        }

        public void PlaceBet(double bet, int dognum)
        {
            if (bet >= 5)
            {
                MyBet = bet;
                DogNum = dognum;
                betPlaced = true;
            }
            else
            {
                MyBet = 0;
                betPlaced = false;
            }
        }


        public void RoundWon()
        {
            Cash = Cash + MyBet;
        }

        public void RoundLost()
        {
            Cash = Cash - MyBet;
        }

        public string GetBalance()
        {
            string message;
            message = this.Name + " has " + this.Cash + " bucks.";
            return message;
        }

        public string GetBet()
        {
            string message;

            if (betPlaced == true)
            {
                message = this.Name + " bets " + this.MyBet + " on dog #" + this.DogNum;
            }
            else
            {
                message = this.Name + "has not placed a bet yet";
            }

            return message;
        }        
    }
}
