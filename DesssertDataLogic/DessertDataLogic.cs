
using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesssertDataLogic
{
    public class DessertDataLogic
    {
        IPurchaseDataService interfaceDL; 
        List<userAccounts> accounts = new List<userAccounts>();

        public DessertDataLogic()
        {
            interfaceDL = new InMemoryData();
            //interfaceDL = new TextFilePurchasedService();
            //interfaceDL = new JsonPurchasedService();
            //interfaceDL = new dbPurchasedService();
        }
        public List<userAccounts> GetAccounts()
        {
            return interfaceDL.GetAccounts();
        }
        public List<PurchaseRecord> GetAllPurchases()
        {
            return interfaceDL.GetAllPurchases();
        }
        public void SavePurchase(PurchaseRecord record)
        {
            interfaceDL.SavePurchase(record);
        }

    }
}