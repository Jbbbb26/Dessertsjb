using DessertCommon;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesssertDataLogic
{
    public class TextFilePurchasedService : IPurchaseDataService
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "purchased.txt");

        public void SavePurchasedRecord(PurchaseRecord record)
        {
            Console.WriteLine("ggggg");
            var line = $"{record.UserName}|{record.Items}|{record.Payment}|{record.Change}";
            File.AppendAllText(filePath, line + Environment.NewLine);
        }

        public List<PurchaseRecord> LoadAllPurchasedRecords()
        {
            var records = new List<PurchaseRecord>();
            if (!File.Exists(filePath))
                return records;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
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
