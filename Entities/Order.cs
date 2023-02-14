using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public static class Order
    {
         public static int OrderMethod()
        {
            ReadAllAvailableGadgets.RefreshFile();
            ReadAllAvailableGadgets.ReadFromTextFile();
            Console.Write("Enter item number: ");
            int pick = int.Parse(Console.ReadLine());
            var order = ReadAllAvailableGadgets.gadgets;

            {
            if (pick == 1)
            {
                 try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Item selected : {order[pick-1].ToString()}");
                    Console.WriteLine($"Product name = {ReadAllAvailableGadgets.gadgets[0].ProductName}, Product features = {ReadAllAvailableGadgets.gadgets[0].Uniqueness}, Price tag = {ReadAllAvailableGadgets.gadgets[0].Price}.");
                    var gadget = ReadAllAvailableGadgets.gadgets[0].Price;
                    Console.Write("Press 1: to continue with payment.\n0: to go back to order menu. Enter Your option: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string num = (Console.ReadLine());

                    switch (num)
                    {
                        case "1":
                        {
                            int amountInWallet = 1000; //int.Parse(Wallet.wallet);
                            var answer = amountInWallet - gadget;
                            Console.WriteLine($"Processing...\nAvailable balance now ${answer}.\n***Thanks for shopping with us we hope to serve you better next time.");
                            Console.ReadKey();

                            Order.OrderMethod();
                            break;
                        }
                        case "2":
                        {
                            Order.OrderMethod();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if(pick == 2)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(order[pick-1].ToString());
                    Console.WriteLine($"Product name = {ReadAllAvailableGadgets.gadgets[1].ProductName}, Product features = {ReadAllAvailableGadgets.gadgets[1].Uniqueness}, Price tag = {ReadAllAvailableGadgets.gadgets[1].Price}.");
                    var gadget = ReadAllAvailableGadgets.gadgets[1].Price;
                    Console.Write("Press 1 to continue with payment. 0: to go back to order menu. Enter Your option: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string num = (Console.ReadLine());

                    switch (num)
                    {
                        case "1":
                        {
                            int amountInWallet = 1000; //int.Parse(Wallet.wallet);
                            var answer = amountInWallet - gadget;
                            Console.WriteLine($"Money deducted from your wallet...\nAvailable balance now ${answer}.\n***Thanks for shopping with us we hope to serve you better next time.");
                            Order.OrderMethod();
                            break;
                        }
                        case "2":
                        {
                            Order.OrderMethod();
                            break;
                        }
                    } 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (pick == 3)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(order[pick-1].ToString());
                    var obj = new Gadgets();
                    var gadget = ReadAllAvailableGadgets.gadgets[2].Price;
                    Console.ForegroundColor = ConsoleColor.White;

                     Console.Write("Press 1 to continue with payment or 0 to go back to order menu. Enter Your option: ");
                    string num = (Console.ReadLine());

                    switch (num)
                    {
                        case "1":
                        {
                            int amountInWallet = 1000; //int.Parse(Wallet.wallet);
                            var answer = amountInWallet - gadget;
                            Console.WriteLine($"Money deducted from your wallet...\nAvailable balance now ${answer}.\n***Thanks for shopping with us we hope to serve you better next time.");
                            Console.WriteLine("Would you wish to purchase another gadget?.");
                            Order.OrderMethod();
                            break;
                        }
                        case "2":
                        {
                            Order.OrderMethod();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 1000;
            }
                    
        }
    }
}