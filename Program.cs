using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using DessertPurchasingLogic;
namespace Dessertsjb

{
    internal class Program
    {
        private static string userName = string.Empty;
        private static string userPass = string.Empty;
        private static PurchasingProcess process = new PurchasingProcess();
        static void Main(string[] args)
        {
            Console.WriteLine("Arise Dessert Shop");
            Console.WriteLine("--------------");

            do
            {
                Console.WriteLine("Enter Username");
                userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                userPass = Console.ReadLine();

                if (!process.ValidateAccountLogin(userName, userPass))
                {
                    Console.WriteLine("Failed: Incorrect Username or Password. Please try again.");
                }
            } while (!process.ValidateAccountLogin(userName, userPass));

            Console.WriteLine("-----------");
            Console.WriteLine($"Welcome to Arise Dessert Shop {userName}");

            displayFlavorsCake();
            displayFlavorsDonut();

            int payment = getPayment();
            while (true)
            {
                int choice;
                Console.Write("Choose from (1-6) to add item, [7] to view cart , [8] to check out,  [9] to View Recent, or [0] to exit: ");
                String input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter between 0-6 only");
                    Console.WriteLine("-------------------");
                    continue;
                }
                switch (choice)

                {
                    case 0:
                        Console.WriteLine("Thank you for purchasing!");
                        return;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:


                        Console.Write("Enter Quantity: ");
                        int quantity;
                        String input1 = Console.ReadLine();
                        if (!int.TryParse(input1, out quantity) || quantity <= 0)
                        {
                            Console.WriteLine("Please enter valid quantity");
                            Console.WriteLine("-----------------");
                            break;
                        }
                        process.addItem(choice, quantity);

                        Console.WriteLine($"{quantity} of {process.getFlavors(choice)} added to cart successfully!");

                        break;


                    case 7:
                        Console.WriteLine("-----Your Cart--------");
                        if (!process.cartCount())
                        {
                            Console.WriteLine("Your Cart is Empty");
                        }
                        else
                        {
                            int totalCart = 0;
                            var cartDetails = process.getCartDetails();
                            foreach (var item in cartDetails)
                            {
                                Console.WriteLine("-----------------------");

                                Console.WriteLine($"{item.flavor} x {item.quantity} = {item.subTotal} PHP");
                                totalCart += item.subTotal;

                            }
                            Console.WriteLine($"Total in cart: {totalCart}PHP");
                        }
                        Console.WriteLine("-----------------------");

                        Console.WriteLine("Dou you want to remove an item in your cart?(y/n)");
                        String removeResponse = Console.ReadLine();
                        if (removeResponse == "y")
                        {
                            Console.WriteLine("Enter the number of item you want to remove:");
                            String itemtoRemove = Console.ReadLine();

                            int.TryParse(itemtoRemove, out int itemIndex);

                            if (process.removeItem(itemIndex))
                            {
                                Console.WriteLine("Item remove successfully!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("No item to remove");
                        }

                        break;

                    case 8:
                        int totalCost = process.TotalCost();
                        if (totalCost == 0)
                        {
                            Console.WriteLine("Your cart is empty. Add items before Checkout");
                        }
                        if (payment >= totalCost)
                        {
                            payment -= totalCost;
                            Console.WriteLine($"Purchase Successful! Total Amount paid: {totalCost} PHP");
                            Console.WriteLine($"Remaining Balance{payment}PHP");
                            process.ProcessPurchase(userName);
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient Balance. You need {totalCost}PHP to buy this item.");
                        }

                        break;
                    case 9:
                        Console.WriteLine("Recent Purchases:");
                        var userPurchases = process.GetPurchasesByUser(userName);
                        if (userPurchases.Count == 0)
                        {
                            Console.WriteLine("No recent purchases found for you.");
                        }
                        else
                        {
                            foreach (var record in userPurchases)
                            {
                                Console.WriteLine("-----------------------");
                                Console.WriteLine($"{record.UserName}");
                                Console.WriteLine($"Item: {record.Items}");
                                Console.WriteLine($"Price: {record.Price} PHP");
                                Console.WriteLine($"Quantity: {record.Quantity}");
                                Console.WriteLine($"Subtotal: {record.Subtotal} PHP");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid, Please enter a valid option(0-8");
                        Console.WriteLine("----------------");
                        break;
                }
            }
        }
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
        static int getPayment()
        {
            Console.WriteLine("");
            Console.Write("Enter your Money 30pesos upwards:");
            String input = Console.ReadLine() ?? "";
            Console.WriteLine();
            int payment;
            if (int.TryParse(input, out payment) && process.ValidateMoney(payment))
            {
                return payment;
            }
            Console.WriteLine("Insufficient money. Please enter an amount of 30 PHP or more:");
            return getPayment();
        }
    }
}
