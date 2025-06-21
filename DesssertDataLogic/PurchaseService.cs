//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DessertCommon;
//using static DessertCommon.userAccounts;
//namespace DesssertDataLogic
//{
//    public class PurchaseService
//    {
//        private readonly IPurchaseDataService dataService;

//        public PurchaseService()
//        {
//            // Swap implementations here as needed:
//            dataService = new TextFilePurchasedService();
//            // dataService = new InMemoryPurchaseService();
//            //dataService = new JsonFilePurchaseService();
//        }
//        public void Save(PurchaseRecord record)
//        {
//            dataService.SavePurchasedRecord(record);
//        }

//        public List<PurchaseRecord> Load()
//        {
//            return dataService.LoadAllPurchasedRecords();
//        }
//    }
//}



