    using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DesssertDataLogic
{
    public class dbPurchasedService : IPurchaseDataService
    {

        List<userAccounts> useraccounts = new List<userAccounts>();
        List<PurchaseRecord> purchaseRecords = new List<PurchaseRecord>();
        static string connectionString = "Data Source =TOYANGG\\SQLEXPRESS; Initial Catalog = Dessert; Integrated Security = True; TrustServerCertificate=True;";
        static SqlConnection sqlConnection;

        public dbPurchasedService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        
        public List<userAccounts> GetAccounts()
        {
            string selectStatement = "Select * from accounts";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
               useraccounts.Add(new userAccounts
                {
                    userName = reader["Username"].ToString(),
                    Pass = reader["Password"].ToString()
                });
            }

            sqlConnection.Close();
            return useraccounts;
        }
        

        public List<PurchaseRecord> GetAllPurchases()
        {
            string selectStatement = "Select * from purchased";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                purchaseRecords.Add(new PurchaseRecord
                {
                    UserName = reader["Username"].ToString(),
                    Items = reader["Item"].ToString(),
                    Price = Convert.ToInt32(reader["Price"]),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    Subtotal = Convert.ToInt32(reader["Subtotal"])

                });
            }

            sqlConnection.Close();
            return purchaseRecords;
        }

        public void SavePurchase(PurchaseRecord record)
        {
            string insertPurchased = "INSERT INTO purchased (Username, Item, Price, Quantity, Subtotal) VALUES (@Username, @Item, @Price, @Quantity, @Subtotal)";
            using (SqlCommand command = new SqlCommand(insertPurchased, sqlConnection))
            {
                command.Parameters.AddWithValue("@Username", record.UserName);
                command.Parameters.AddWithValue("@Item", record.Items);
                command.Parameters.AddWithValue("@Price", record.Price);
                command.Parameters.AddWithValue("@Quantity", record.Quantity);
                command.Parameters.AddWithValue("@Subtotal", record.Subtotal);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
