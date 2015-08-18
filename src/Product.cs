using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    class Product
    {
        private readonly int capacity = 20;  //добавил емкость автомата для каждого вида товара 
        private String _name;
        private int _rublePrice;
        private int _rest;

        public String name
        {
            private set { _name = value;  }
            get { return this._name; }
        }

        public int rublePrice
        {
            private set { _rublePrice = value; }
            get { return this._rublePrice; }
        }

        public int rest
        {
            private set { _rest = value; }
            get { return this._rest; }
        }
 
        public bool giveOne()
        {
            if (rest == 0) { return false; }
            
            --rest;
            return true;
        }

        public bool load(int number)
        {
            if (rest + number <= capacity)
            {
                rest += number;
                return true;
            }
            else
            {
                return false;
            }

        }

        public Product(String name, int rublePrice, int rest)
        {
            this.name = name;
            this.rublePrice = rublePrice;
            this.rest = rest;
        }
    }
}
