using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesssertDataLogic
{
    public class JsonPurchasedService : IPurchaseDataService
    {
        List<userAccounts> accounts = new List<userAccounts>();
        List<PurchaseRecord> purchaseRecords = new List<PurchaseRecord>();
        string accountfilepath = "accounts.json";
        string purchasefilepath = "purchased.json";
        public JsonPurchasedService()
        {
            ReadJsonDataFromFile();
        }
        public void ReadJsonDataFromFile()
        {
            string accountJsonText = File.ReadAllText(accountfilepath);
            string purchaseJsonText = File.ReadAllText(purchasefilepath);
            accounts = JsonSerializer.Deserialize<List<userAccounts>>(accountJsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
            purchaseRecords = JsonSerializer.Deserialize<List<PurchaseRecord>>(purchaseJsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }
        public List<userAccounts> GetAccounts()
        {
            return accounts;
        }

        public List<PurchaseRecord> GetAllPurchases()
        {
            return purchaseRecords;
        }

        public void SavePurchase(PurchaseRecord record)
        {
            purchaseRecords.Add(record);
            string jsonString = JsonSerializer.Serialize(purchaseRecords, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(purchasefilepath, jsonString);
        }
    }
}
