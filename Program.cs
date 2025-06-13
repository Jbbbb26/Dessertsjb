using System;
using System.ComponentModel;
using DessertPurchasingLogic;
namespace Dessertsjb

{
    internal class Program
    {
        static void Main(string[] args)
        {

            

        

            Console.WriteLine("Arise Dessert Shop");
            Console.WriteLine("--------------");


        
        PurchasingProcess process = new PurchasingProcess();
            
            String userName = string.Empty;
            String userPass = string.Empty;
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

            //method calling for payment


            displayFlavorsCake();
            displayFlavorsDonut();


            int payment = getPayment();

            PurchasingProcess.ShoppingCart cart = new PurchasingProcess.ShoppingCart();
            cart.Flavors = PurchasingProcess.Flavors;
            cart.Prices = PurchasingProcess.Prices;
           
            
            while (true) 
            {
                int choice;
                    
                //method calling for flavors
             
                Console.Write("Choose from (1-6) to add item, [7] to view cart , [8] to check out, or [0] to exit: ");
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
                        if(!int.TryParse(input1,out quantity) || quantity <= 0)
                        {
                            Console.WriteLine("Please enter valid quantity");
                            Console.WriteLine("-----------------");
                            break;
                        }
                        cart.addItem(choice,quantity);
                        
                        Console.WriteLine($"{quantity} of {PurchasingProcess.Flavors[choice - 1]} added to cart successfully!");
                        break;

                           
                        case 7:
                            Console.WriteLine("-----Your Cart--------");
                        if (cart.cartEmpty())
                        {
                            Console.WriteLine("Your Cart is Empty");
                        }
                        else
                        {
                            int totalCart = 0;
                            var cartDetails = cart.GetCartDetails();
                            foreach (var item in cartDetails)
                            {
                                Console.WriteLine($"{item.flavor} x {item.quantity} = {item.subtotal} PHP");
                                totalCart += item.subtotal;

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

                            if (int.TryParse(itemtoRemove, out int itemIndex) && itemIndex > 0 && itemIndex <= cart.GetCartDetails().Count) ;

                            if (cart.removeItem(itemIndex))
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
                                int totalCost = cart.TotalCost();
                              
                                
                                if (totalCost == 0)
                                {
                                    Console.WriteLine("Your cart is empty. Add items before Checkout");
                                }
                                if (payment >= totalCost)
                                {
                                    payment -= totalCost;
                                    Console.WriteLine($"Purchase Successful! Total Amount paid: {totalCost} PHP");
                                    Console.WriteLine($"Remaining Balance{payment}PHP");
                                    cart.clearCart();
                                   
                                }
                                else
                                {
                                    Console.WriteLine($"Insufficient Balance. You need {totalCost}PHP to buy this item.");
                                }

                                break;
                            default:
                                Console.WriteLine("Invalid, Please enter a valid option(0-8");
                                Console.WriteLine("----------------");
                                break;
                            }    }
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
                Console.Write("Enter your Money 30pesos upwards:");
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
       

    }
}
    