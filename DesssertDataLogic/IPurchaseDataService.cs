using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DessertCommon;
namespace DesssertDataLogic
{

    public interface IPurchaseDataService
    {
        public List<userAccounts> GetAccounts();
        public List<PurchaseRecord> GetAllPurchases();
        public void SavePurchase(PurchaseRecord record);
        

    }
}