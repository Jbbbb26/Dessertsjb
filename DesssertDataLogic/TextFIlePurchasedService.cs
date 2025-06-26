using DessertCommon;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesssertDataLogic
{
    public class TextFilePurchasedService : IPurchaseDataService
    {
        string accountfilePath = "accounts.txt";
        string purchasefilePath = "purchased.txt";
        List<userAccounts> useraccounts = new List<userAccounts>();
        List<PurchaseRecord> purchaseRecords = new List<PurchaseRecord>();

        public TextFilePurchasedService()
        {
            getDataFromFile();
        }
        public void getDataFromFile()
        {
                var lines = File.ReadAllLines(accountfilePath);
                foreach (string line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                        userAccounts account = new userAccounts
                        {
                            userName = parts[0],
                            Pass = parts[1]
                        };
                        useraccounts.Add(account);
                    }
                }
        }
        public List<userAccounts> GetAccounts()
        {
            return useraccounts;
        }
        public List<PurchaseRecord> GetAllPurchases()
        {
           
                var lines = File.ReadAllLines(purchasefilePath);
                foreach (string line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        PurchaseRecord record = new PurchaseRecord
                        {
                            UserName = parts[0],
                            Items = parts[1],
                            Price = int.Parse(parts[2]),
                            Quantity = int.Parse(parts[3]),
                            Subtotal = int.Parse(parts[4])
                        };
                        purchaseRecords.Add(record);
                    }
                }
            
            return purchaseRecords;
        }

        public void SavePurchase(PurchaseRecord record)
        {
            foreach (var account in useraccounts)
            {
                if (account.userName == record.UserName)
                {
                    string line = $"{record.UserName},{record.Items},{record.Price},{record.Quantity},{record.Subtotal}\n";
                    File.AppendAllText(purchasefilePath, line);
                    return;
                }
            }
        }
        
        

    }
}
