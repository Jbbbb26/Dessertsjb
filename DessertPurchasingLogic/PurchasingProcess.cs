using DesssertDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertPurchasingLogic
{
    public class PurchasingProcess
    {

        public static  string[] Flavors = { "Black Forest", "Pistachio", "Red Velvet", "Classic Bavarian", "ChocoButternut", "HoneyGlazed" };
        public static  int[] Prices = { 45, 60, 60, 30, 35, 40 };



        public static int purchasedItem(int payment, String[] flavors, int[] price, int choice, int quantity)
        {

            int totalPrice = price[choice - 1] * quantity;

            if (payment >= totalPrice)
            {
                payment -= totalPrice;

                return payment;
            }
            return -1;
        }
        public bool ValidateAccountLogin(String userName, String userPass)
        {
            DessertDataLogic ddLogic = new DessertDataLogic();
            return ddLogic.ValidateAccountLogin(userName, userPass);
        }

        public class ShoppingCart
        {
            List<int> cart = new List<int>();
            List<int> cartQuantities = new List<int>();

            public String[] Flavors { get; set; }
            public int [] Prices { get; set; }

            public void addItem(int itemIndex, int quantity)
            {
                cart.Add(itemIndex);
                cartQuantities.Add(quantity);
            }
            public List<(string flavor, int quantity, int subtotal)> GetCartDetails()
            {
                {
                    var details = new List<(string, int, int)>();

                    for (int i = 0; i < cart.Count; i++)
                    {
                        int index = cart[i] - 1;
                        int subtotal = Prices[index] * cartQuantities[i];
                        details.Add((Flavors[index], cartQuantities[i], subtotal));
                    }

                    return details;
                }



            }
            public bool removeItem(int itemNumber)
            {
                if(itemNumber > 0 && itemNumber <= cart.Count)
                {
                    int index = itemNumber - 1;
                    cart.RemoveAt(index);
                    cartQuantities.RemoveAt(index);
                    return true;
                }
                return false;
            }
        
            public int TotalCost()
            {
                int total = 0;
                for(int i = 0; i < cart.Count; i++)
                {
                    int index = cart[i] - 1;
                    total += Prices[index] * cartQuantities[i];
                }
                return total;
            }
            public bool cartEmpty()
            {
                return cart.Count == 0;
            }
            public void clearCart()
            {
                cart.Clear();
                cartQuantities.Clear();
            }
        
        }
    }
}
