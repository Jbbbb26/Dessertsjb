using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DessertCommon;
using System.IO;

namespace DesssertDataLogic
{
   public class TextFilePurchasedService : IPurchaseDataService
    {
       
       
           private readonly string filePath = "purchased.txt";
        
    
    public void SavePurchasedRecord(PurchaseRecord record)
        {
            string line = $"{record.UserName}|{record.Items}|{record.Payment}|{record.Change}";
            File.AppendAllText(filePath, line + Environment.NewLine);
        }
        public List <PurchaseRecord> LoadAllPurchasedRecords()
        {
            var records = new List<PurchaseRecord>();
            if (!File.Exists(filePath))
                return records;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    records.Add(new PurchaseRecord
                    {
                        UserName = parts[0],
                        Items = parts[1],
                        Payment = int.Parse(parts[2]),
                        Change = int.Parse(parts[3])
                    });
                }
            }
            return records;
        }
    }
}
        
    
    
