using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    enum Coins { one = 1, two = 2, five = 5, ten = 10 };

    class MoneyHolder
    {
        public CoinsBox coinsBox;
        private  int _deposit;
        public int deposit
        {
            get { return this._deposit; }
            private set { _deposit = value; }
        }

        public MoneyHolder(int deposit, CoinsBox coinsBox)
        {
            this.deposit = deposit;
            this.coinsBox = coinsBox;
        }

        public void addCoin(Coins coin)
        {
            switch(coin)
            {
                case Coins.one: { coinsBox.addOneRubleCoin(); }
                    break;
                case Coins.two: { coinsBox.addTwoRubleCoin(); }
                    break;
                case Coins.five: { coinsBox.addFiveRubleCoin(); }
                    break;
                case Coins.ten: { coinsBox.addTenRubleCoin(); }
                    break;

            }
            deposit += (int)coin;
        }

        public bool tryWithdrawMoney(int value)
        {
            if (value > deposit) { return false; }
          
            deposit -= value;
            return true;
        }

        public bool giveResidue()
        {
            int tryDeposit = deposit;
            int i10;
            i10 = tryDeposit / 10;
            if (i10 > 0) 
            {
                if(i10 > coinsBox.tenRubleCoinsCount)
                {
                    tryDeposit -= coinsBox.tenRubleCoinsCount * 10;
                    coinsBox.removeTenRubleCoins(coinsBox.tenRubleCoinsCount);                  
                }
                else
                {                    
                    tryDeposit -= i10 * 10;
                    coinsBox.removeTenRubleCoins(i10);
                }
            }


            i10 = tryDeposit / 5;
            if (i10 > 0)
            {
                if (i10 > coinsBox.fiveRubleCoinsCount)
                {
                    tryDeposit -= coinsBox.fiveRubleCoinsCount * 5;
                    coinsBox.removeFiveRubleCoins(coinsBox.fiveRubleCoinsCount);     
                }
                else
                {
                    tryDeposit -= i10 * 5;
                    coinsBox.removeFiveRubleCoins(i10);             
                }
            }

            i10 = tryDeposit / 2;
            if (i10 > 0)
            {
                if (i10 > coinsBox.twoRubleCoinsCount)
                {             
                    tryDeposit -= coinsBox.twoRubleCoinsCount * 2;
                    coinsBox.removeTwoRubleCoins(coinsBox.twoRubleCoinsCount);
                }
                else
                {
                    tryDeposit -= i10 * 2;
                    coinsBox.removeTwoRubleCoins(i10);                 
                }
            }

            i10 = tryDeposit / 1;
            if (i10 > 0)
            {
                if (i10 > coinsBox.oneRubleCoinsCount)
                {
                    tryDeposit -= coinsBox.oneRubleCoinsCount * 1;
                    coinsBox.removeOneRubleCoins(coinsBox.oneRubleCoinsCount);               
                }
                else
                {                 
                    tryDeposit -= i10 * 1;
                    coinsBox.removeOneRubleCoins(i10);
                }
            }

            if (tryDeposit != 0) { return false; }

            deposit = tryDeposit;
            return true;
        }
    }
}
