using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    class View
    {
        private Stockpile stockpile;
        private MoneyHolder moneyHolder;

        public View(Stockpile stockpile, MoneyHolder moneyHolder)
        {
            this.stockpile = stockpile;
            this.moneyHolder = moneyHolder;
        }

        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("Ваш депозит: "+moneyHolder.deposit.ToString()+ "\n\n" +
                              "Внесите необходимую сумму, напечатайте цифру нужого вам товара и нажмите ввод. \n");

            int i = 1;
            foreach (Product product in stockpile.getProducts())
            {
                Console.WriteLine( (i++) +": " + product.name + " " + "Стоймость: " + product.rublePrice + " " + "Остаток: " + product.rest);
            }

            Console.WriteLine((i++) + ": " + "Вернуть сдачу");
            Console.WriteLine("0" + ": " + "Выйти из программы");

            Console.WriteLine("\n");
            Console.WriteLine("Симулировать добавление монетки \n");

            Console.WriteLine("5: 1 рубль \n" + 
                              "6: 2 рубля \n" +
                              "7: 5 рублей \n" +
                              "8: 10 рублей \n");

            Console.WriteLine("Осталось мелочи в автомате: \n"
                             +"монета 1 рубль: " + moneyHolder._coinsBox.oneRubleCoinsCount + "\n" 
                             +"монета 2 рубля: " + moneyHolder._coinsBox.twoRubleCoinsCount + "\n" 
                             +"монета 5 рублей: " + moneyHolder._coinsBox.fiveRubleCoinsCount + "\n" 
                             +"монета 10 рублей: " + moneyHolder._coinsBox.tenRubleCoinsCount + "\n");
        }

        public int readInput()
        {
            int menuItem;

            while (!Int32.TryParse(Console.ReadLine(), out menuItem))
            {
                Console.Clear();
                Console.WriteLine("Извините я не понял ваш запрос, введите пожалуйста цифру нужного вам товара");
                showMenu();
            }

            return menuItem;
        }

        public void showSuccesfulBuyMessage(Product product)
        {
            Console.Clear();
            Console.WriteLine("Вы успешно купили "+ product.name + 
                              " Нажмите ввод для возвращения в меню");
            Console.ReadLine();
        }

        public void showNotEnoughMoneyMessage(Product product)
        {
            Console.Clear();
            Console.WriteLine("Вам не хватает еще " + (product.rublePrice - moneyHolder.deposit).ToString() + " рублей \n" +
                              "Нажмите ввод для возвращения в меню");
            Console.ReadLine();
        }

        public void showNotEnoughProductsMessage(Product product)
        {
            Console.Clear();
            Console.WriteLine("Извините, у нас кончился " + product.name);
            Console.ReadLine();
        }

        public void showNotChosenMenuItemMessage()
        {
            Console.Clear();
            Console.WriteLine("Извините, у нас нет такого пункта меню ");
            Console.ReadLine();
        }

        public void showHasNotResidueMessage()
        {
            Console.Clear();
            Console.WriteLine("Извините, у нас кончилась сдача. Позвоните по телефону 8-916-хх-хх-ххх или купите что нибудь.");
            Console.ReadLine();
        }
    }
}
