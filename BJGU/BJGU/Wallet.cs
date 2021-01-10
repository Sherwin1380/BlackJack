using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJGU
{


    class Wallet
    {
        private int cash;
        private int WinningCash;

        // set up start amount of money - £500
        public int StartingWallet()
        {
            return cash = 500;
        }

        //during the game update amount of money whe will click DEAL
        public int UpdateWallet(int Wallet, int Cash)
        {
                this.cash = Wallet - Cash;   
            return cash;
        }

        //update wallet for winning Player or Opponent
        public int WinnigMoney(int Wallet, int Cash)
        {
            this.WinningCash = Wallet + (Cash * 2);
            return WinningCash;
        }


    }


}
