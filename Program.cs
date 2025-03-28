using System;
using DessertPurchasingLogic;
namespace Dessertsjb

{
    internal class Program
    {
        static void Main(string[] args)
        {




            String[] flavors = { "Balck Forest", "Pistaccio", "Red Velvet", "Classic Bavarian", "ChocoButternut", "HoneyGlazed" };
            int[] price = { 45, 60, 60, 30, 35, 40 };
            Console.WriteLine("Arise Dessert Shop");
            Console.WriteLine("--------------");

            String name;
            String pass;
            do
            {
                Console.WriteLine("Enter Username");
                name = Console.ReadLine();
                Console.WriteLine("Enter Password");
                pass = Console.ReadLine();
              
                if (!PurchasingProcess.validateLogin(name, pass))
                {
                    Console.WriteLine("Failed: Incorrect Username or Password. Please try again.");
                }
            } while (!PurchasingProcess.validateLogin(name, pass));

            Console.WriteLine("-----------");
            Console.WriteLine($"Welcome to Arise Dessert Shop {name}");
            
            //method calling for payment

            int payment = getPayment();

            {

            }
            while (true)
            {
                

                //method calling for flavors
                displayFlavorsCake();
                displayFlavorsDonut();
                Console.Write("Choose from 1-6 or 0 to exit :");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Enter Quantity");

                        int quantity = Convert.ToInt32(Console.ReadLine());
                        int newBalance = PurchasingProcess.purchasedItem(payment, flavors, price, choice,quantity);
                        
                      
                        if(newBalance >= 0)
                        {
                            payment = newBalance;
                            Console.WriteLine($"You bought {quantity} of {flavors[choice - 1]}.");
                            Console.WriteLine($"Total cost: {price[choice - 1] * quantity} PHP.");
                            Console.WriteLine($"Available balance: {newBalance} PHP.");
                            Console.WriteLine("");
                           
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance, Please enter a smaller quantity or other item");
                            Console.WriteLine("--------------");
                            Console.WriteLine("");
                        }

                        break;
                    case 0:
                                Console.WriteLine($"Thank u for purchasing!");
                                return;

                            default:
                                Console.WriteLine("Invalid, Please enter a valid option");
                                break;
                            }
            }
        }
        //method to display or to call the flavors available
        static void displayFlavorsCake()
        {
            Console.WriteLine("Cake Sliced");
            Console.WriteLine("[1]Black Forest 45 php");
            Console.WriteLine("[2]Pistaccio 60 php");
            Console.WriteLine("[3]Red Velvet 60 php");
            Console.WriteLine("---------");
        }
        static void displayFlavorsDonut()
        {
            Console.WriteLine("Donut");
            Console.WriteLine("[4]Classic Bavarian 30 php ");
            Console.WriteLine("[5]Choco Butternut 35php");
            Console.WriteLine("[6]Honey Glazed 40php");
            Console.WriteLine("[0] to exit");
            Console.WriteLine("---------");
        }
        //method to know if the payment is greater than 20 to proceed
        static int getPayment()
        {
            int payment;
            do
            {
                Console.WriteLine("");
                Console.Write("Enter your Money:");
                String input = Console.ReadLine()??"";
                Console.WriteLine();
                

                if (!int.TryParse(input,out payment))

                {
                    Console.WriteLine("Invalid Input, Please Input Money");
                    continue;
                }
                if(payment<30)
                {
                    Console.WriteLine("You Dont have Enough Balance");
                }
            } while (payment < 30);
            return payment;
        }
       

        //static int purchasedItem(int payment, String[] flavors, int[] price, int choice)
        //{
        //    Console.WriteLine("Enter Quantity");
        //    int quantity = Convert.ToInt32(Console.ReadLine());
        //    int totalPrice = price[choice - 1] * quantity;

        //    if (payment >= totalPrice)
        //    {
        //        payment -= totalPrice;
        //        Console.WriteLine($"You Bought {quantity} of {flavors[choice - 1]}");
        //        Console.WriteLine($"Your total Cost is {totalPrice}");
        //        Console.WriteLine($"Your available balance is {payment}");


        //        if (payment < 30)
        //        {
        //            Console.WriteLine("You cannot purchased more, thank u for buying");

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient Balance Please Select the right Item or Quantity");
        //    }

        //        return payment;
        //}
    }
}
    