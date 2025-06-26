using DessertCommon;
using DesssertDataLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertPurchasingLogic
{
    public class PurchasingProcess
    {
        DessertDataLogic ddLogic = new DessertDataLogic();
        string[] Flavors = { "Black Forest", "Pistachio", "Red Velvet", "Classic Bavarian", "ChocoButternut", "HoneyGlazed" };
        int[] Prices = { 45, 60, 60, 30, 35, 40 };
        List<int> cart = new List<int>();
        List<int> cartQuantities = new List<int>();
        List<(string, int, int)> cartDetails = new List<(string, int, int)>();
        public List<userAccounts> GetAccounts()
        {
            return ddLogic.GetAccounts();
        }
        public List<PurchaseRecord> GetAllPurchases()
        {
            return ddLogic.GetAllPurchases();
        }   
   
        public bool ValidateAccountLogin(string userName, string userPass)
        {
            foreach (var account in GetAccounts())
            {
                if (account.userName == userName && account.Pass == userPass)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidateMoney(int money)
        {
            if (money < 30)
            {
                return false;
            }
            return true;
        }
        public bool ValidatePurchase(int itemIndex, int payment)
        {
            if (itemIndex < 1 || itemIndex > Flavors.Length)
            {
                return false;
            }
            int price = Prices[itemIndex - 1];
            if (payment < price)
            {
                return false;
            }
            return true;
        }
        public int TotalCost()
        {
            int total = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                int index = cart[i] - 1;
                total += Prices[index] * cartQuantities[i];
            }
            return total;
        }
        public void ProcessPurchase(string userName)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                int itemIndex = cart[i];
                int quantity = cartQuantities[i];
                int price = Prices[itemIndex - 1];
                int subTotal = price * quantity;
                purchasedItem(userName, itemIndex, quantity, price, subTotal); 
            }
            clearCart();
        }

        public void purchasedItem(string userName, int flavors, int quantity, int price, int subTotal)
        {
            var record = new PurchaseRecord
            {
                UserName = userName,
                Items = Flavors[flavors - 1],
                Price = price,
                Quantity = quantity,
                Subtotal = subTotal
            };
            ddLogic.SavePurchase(record);
        }
        public List<PurchaseRecord> GetPurchasesByUser(string userName)
        {
            List<PurchaseRecord> userPurchases = new List<PurchaseRecord>();

            foreach (var recentPurchased in GetAllPurchases())
            {
                if (recentPurchased.UserName == userName)
                {
                    userPurchases.Add(recentPurchased);
                }
            }

            return userPurchases;
        }

        public void addItem(int itemIndex, int quantity)
        {
            cart.Add(itemIndex);
            cartQuantities.Add(quantity);
        }
        public List<(string flavor, int quantity, int subTotal)> getCartDetails()
        {
            cartDetails.Clear();
            for (int i = 0; i < cart.Count; i++)
            {
                int index = cart[i] - 1;
                string flavor = Flavors[index];
                int price = Prices[index];
                int quantity = cartQuantities[i];
                int subtotal = price * quantity;
                cartDetails.Add((flavor, quantity, subtotal));
            }
            return cartDetails;
        }
        public bool removeItem(int itemNumber)
        {
            if (itemNumber > 0 && itemNumber <= cart.Count)
            {
                int index = itemNumber - 1;
                cart.RemoveAt(index);
                cartQuantities.RemoveAt(index);
                cartDetails.Clear();
                getCartDetails();
                return true;
            }
            return false;
        }

        public string getFlavors(int index)
        {
            return Flavors[index - 1 ];


        }
        public bool cartCount()
        {
            if (cart.Count == 0)
            {
                return false;
            }
            return true;
        }
        public void clearCart()
        {
            cart.Clear();
            cartQuantities.Clear();
        }
    }
}
