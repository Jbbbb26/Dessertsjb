namespace Dessertsjb

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] price = { 20, 25 };
            Console.WriteLine("Welcome to Graham Bar to Go");
            Console.WriteLine("Flavors");
            Console.WriteLine("[1]Classic[20]");
            Console.WriteLine("[2]Cookis n Cream[25]");

            Console.WriteLine("Enter your Money");
            int payment = Convert.ToInt32(Console.ReadLine());

            while (true)
                if (payment >= 20)
                {
                    Console.WriteLine("Select Flavor 1 for Classic 2 for Cookis n Cream or 0 to exit");

                    int choice = Convert.ToInt16(Console.ReadLine());

                    if (choice == 0)
                    {
                        Console.WriteLine("Thank u, come again");
                        break;
                    }

                    else if (choice == 1)
                    {
                        if (payment >= price[0])
                        {
                            payment = payment - price[0];
                            Console.WriteLine("You bought Classic flavor");
                            Console.WriteLine("your balance is " + payment);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                    }
                    else if (choice == 2)
                    {
                        if (payment >= price[1])
                        {
                            payment = payment - price[1];
                            Console.WriteLine("You bought Cookis n Cream flavor");
                            Console.WriteLine("your balance is " + payment);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please select only from 1 , 2 and 0");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient Balance, Continue to exit and thank u come again!");

                    break;
                }
        }

    }
}
    


