using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesssertDataLogic
{
    public class InMemoryData : IPurchaseDataService
    {
        List<userAccounts> accounts = new List<userAccounts>();
        List<PurchaseRecord> purchaseRecords = new List<PurchaseRecord>();
        public InMemoryData()
        {
            CreateDummyUserAccounts();
        }
        public void CreateDummyUserAccounts()
        {
            userAccounts account1 = new userAccounts();
            account1.userName = "Benedict";

            account1.Pass = "123456";

            accounts.Add(account1);

            userAccounts account2 = new userAccounts
            {
                userName = "John",

                Pass = "111111"
            };

            accounts.Add(account2);

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
            foreach (var account in accounts)
            {
                if (account.userName == record.UserName)
                {
                    purchaseRecords.Add(record);
                    return;
                }
            }
        }
    }
}

