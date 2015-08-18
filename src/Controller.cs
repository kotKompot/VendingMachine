using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    class Controller
    {
        private static bool appRunning;
        private static Stockpile stockpile;
        private static View view;
        private static MoneyHolder moneyHolder;
        private static CoinsBox coinsBox;

        static void Main(string[] args)
        {       
            initialization();

            do
            {
                view.showMenu();

                switch(view.readInput())
                {
                    case 1: 
                    if (stockpile.getProducts()[0].rest > 0) 
                    {
                        if(moneyHolder.tryWithdrawMoney(stockpile.getProducts()[0].rublePrice))
                        {
                            view.showSuccesfulBuyMessage(stockpile.getProducts()[0]);
                            stockpile.getProducts()[0].giveOne();
                        }
                        else
                        {
                            view.showNotEnoughMoneyMessage(stockpile.getProducts()[0]);
                        }
                    }
                    else
                    {
                        view.showNotEnoughProductsMessage(stockpile.getProducts()[0]);
                    }
                        break;

                    case 2: 
                    if (stockpile.getProducts()[1].rest > 0)
                        {
                            if (moneyHolder.tryWithdrawMoney(stockpile.getProducts()[1].rublePrice))
                            {
                                view.showSuccesfulBuyMessage(stockpile.getProducts()[1]);
                                stockpile.getProducts()[1].giveOne();
                            }
                            else
                            {
                                view.showNotEnoughMoneyMessage(stockpile.getProducts()[1]);
                            }
                        } 
                        else
                        {
                            view.showNotEnoughProductsMessage(stockpile.getProducts()[1]);
                        }
                        break;

                    case 3: 
                    if (stockpile.getProducts()[2].rest > 0)
                        {
                            if (moneyHolder.tryWithdrawMoney(stockpile.getProducts()[2].rublePrice))
                            {
                                view.showSuccesfulBuyMessage(stockpile.getProducts()[2]);
                                stockpile.getProducts()[2].giveOne();
                            }
                            else
                            {
                                view.showNotEnoughMoneyMessage(stockpile.getProducts()[2]);
                            }
                        }
                        else
                        {
                            view.showNotEnoughProductsMessage(stockpile.getProducts()[2]);
                        }
                        break;

                    case 4: if (!moneyHolder.giveResidue()) { view.showHasNotResidueMessage();}
                        break;

                    case 5:
                        moneyHolder.addCoin(Coins.one);
                        break;

                    case 6:
                        moneyHolder.addCoin(Coins.two);
                        break;

                    case 7:
                        moneyHolder.addCoin(Coins.five);
                        break;

                    case 8:
                        moneyHolder.addCoin(Coins.ten);
                        break;

                    case 0:
                        appRunning = false;
                        break;

                    default: view.showNotChosenMenuItemMessage();
                        break;
                }

            } while (appRunning);
        }

        private static void initialization()
        {
            appRunning = true;

            List<Product> products = new List<Product>();
            products.Add(new Product("cupcakes", 50, 4));
            products.Add(new Product("cookie", 10, 3));
            products.Add(new Product("wafers", 30, 10));
            stockpile = new Stockpile(products);
            coinsBox = new CoinsBox(20,4,2,1);
            moneyHolder = new MoneyHolder(0, coinsBox);
            view = new View(stockpile, moneyHolder);
            
        }
    }
}
