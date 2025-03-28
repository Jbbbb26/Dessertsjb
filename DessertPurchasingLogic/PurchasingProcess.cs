using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertPurchasingLogic
{
    public class PurchasingProcess
    {
       static String userName = "user1";
        static   String uPass = "0000";
        
       
        public static int purchasedItem(int payment, String[] flavors, int[] price, int choice ,int quantity)
        {

            int totalPrice = price[choice - 1] * quantity;

            if (payment >= totalPrice)
            {
                payment -= totalPrice;

                return payment;
            }
            return -1;
        }
        public static bool validateLogin(String name,String pass)
        {
           
                return name == userName && pass == uPass;
            }
        }
    }
