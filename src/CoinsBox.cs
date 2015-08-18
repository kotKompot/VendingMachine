using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    class CoinsBox
    {
        private int _oneRubleCoinsCount;
        private int _twoRubleCoinsCount;
        private int _fiveRubleCoinsCount;
        private int _tenRubleCoinsCount;

        public int oneRubleCoinsCount
        {
            private set { _oneRubleCoinsCount = value; }
            get { return this._oneRubleCoinsCount;  }
        }

        public int twoRubleCoinsCount
        {
            private set { _twoRubleCoinsCount = value; }
            get { return this._twoRubleCoinsCount; }
        }

        public int fiveRubleCoinsCount
        {
            private set { _fiveRubleCoinsCount = value; }
            get { return this._fiveRubleCoinsCount; }
        }

        public int tenRubleCoinsCount
        {
            private set { _tenRubleCoinsCount = value; }
            get { return this._tenRubleCoinsCount; }
        }

        public CoinsBox(int oneRubleCoinsCount, int twoRubleCoinsCount, int fiveRubleCoinsCount, int tenRubleCoinsCount)
        {
            this.oneRubleCoinsCount = oneRubleCoinsCount;
            this.twoRubleCoinsCount = twoRubleCoinsCount;
            this.fiveRubleCoinsCount = fiveRubleCoinsCount;
            this.tenRubleCoinsCount = tenRubleCoinsCount;
        }

        public void addOneRubleCoin()
        {
            oneRubleCoinsCount++;
        }

        public void addTwoRubleCoin()
        {
            twoRubleCoinsCount++;
        }

        public void addFiveRubleCoin()
        {
            fiveRubleCoinsCount++;
        }

        public void addTenRubleCoin()
        {
            tenRubleCoinsCount++;
        }

        public void removeOneRubleCoins(int removingCount)
        {
            oneRubleCoinsCount -= removingCount; 
        }

        public void removeTwoRubleCoins(int removingCount)
        {
            twoRubleCoinsCount -= removingCount; 
        }

        public void removeFiveRubleCoins(int removingCount)
        {
            fiveRubleCoinsCount -= removingCount; 
        }

        public void removeTenRubleCoins(int removingCount)
        {
            tenRubleCoinsCount -= removingCount; 
        }
    }
}
