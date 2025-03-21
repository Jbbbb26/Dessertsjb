using System;

namespace Dessertsjb

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] flavors = { "Classic", "Cookis n Cream", "Rocky Road" };
            int[] price = { 20, 25, 25 };
            Console.WriteLine("Welcome to Graham Bar to Go");

            //method calling for payment
            int payment = getPayment();
            while (true)
            {


                //method calling for flavors
                displayFlavors();
                Console.Write("Flavor :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine($"You select {flavors[choice - 1]}");
                        Console.Write("Enter Quantity:");
                        int quantity = Convert.ToInt16(Console.ReadLine());
                        int totalPrice = price[choice - 1] * quantity;
                        if (payment >= totalPrice)
                        {
                            payment -= totalPrice;
                            Console.WriteLine($"You Bought {quantity} of {flavors[choice - 1]}");
                            Console.WriteLine($"Your total cost is {totalPrice}");
                            Console.WriteLine($"Your Balance is {payment}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance, Please Select the right Quantity.");

                        }
                        if (payment < 20)
                        {
                            Console.WriteLine("You Dont have enough money to buy more.");
                            Console.WriteLine($"Thank u for purchasing!");
                            return;
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
        static void displayFlavors()
        {
            Console.WriteLine("Flavors");
            Console.WriteLine("[1]Classic 20 php");
            Console.WriteLine("[2]Cookis n Cream 25 php");
            Console.WriteLine("[3]Rocky Road 25 php");
            Console.WriteLine("[0] to exit");
            Console.WriteLine("---------");
        }
        //method to know if the payment is greater than 20 to proceed
        static int getPayment()
        {
            int payment;
            do
            {
                Console.Write("Enter your Money:");
                payment = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (payment < 20)

                {
                    Console.WriteLine("You dont have enough money to buy");

                }
            } while (payment < 20);
            return payment;
        }

    }

}


