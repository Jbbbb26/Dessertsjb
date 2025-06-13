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
       public void SavePurchasedRecord(PurchaseRecord record);
        
            List<PurchaseRecord> LoadAllPurchasedRecords();
        }
    }

