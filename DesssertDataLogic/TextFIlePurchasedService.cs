using DessertCommon;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesssertDataLogic
{
    public class TextFilePurchasedService
    {
        string filePath = "purchased.txt";
        List<userAccounts> useraccounts = new List<userAccounts>();
        public TextFilePurchasedService()
        {
            getDataFromFile();
        }


        private void getDataFromFile()
        {
            useraccounts = new List<userAccounts>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("[DEBUG] purchased.txt not found.");
                return;
            }
            var userAccounts = File.ReadAllLines(filePath);
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');



                if (parts.Length >=3 && parts[0] == "ACC")
                {
                    userAccounts user = new userAccounts
                    {
                        userName = parts[1].Trim(),
                        Pass = parts[2].Trim()
                    };
                    useraccounts.Add(user);
                }
            }
        }
    
       public List<userAccounts> GetAccounts()
        {
            return useraccounts;
        }
        public void SavePurchase(PurchaseRecord record)
        {
            string line = $"PUR|{record.UserName}|{record.Items}|Payment: {record.Payment}|Change: {record.Change}";
            File.AppendAllLines(filePath, new[] { line });
        }
        public List <PurchaseRecord> GetAllPurchases()
        {
            var purchases = new List<PurchaseRecord>();
            if (!File.Exists(filePath)) return purchases;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5 && parts[0] == "PUR")
                {
                    purchases.Add(new PurchaseRecord
                    {
                        UserName = parts[1],
                        Items = parts[2],
                        Payment = int.Parse(parts[3].Replace("Payment: ", "")),
                        Change = int.Parse(parts[4].Replace("Change: ", ""))
                    });
                }
            }
            return purchases;
        }
    }
        //    public void addAcount(userAccounts useraccounts)
        //    {

        //    }
        //}
    }
