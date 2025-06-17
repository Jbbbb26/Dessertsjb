using DessertCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesssertDataLogic
{
    public class InMemoryData
    {

        public class DessertDataLogic
        {
            List<userAccounts> accounts = new List<userAccounts>();

            public DessertDataLogic()
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
            public bool ValidateAccountLogin(String userName, String userPass)
            {
                foreach (var account in accounts)
                {
                    if (account.userName == userName && account.Pass == userPass)
                    {
                        return true;
                    }
                }
                return false;
            }
            public List<userAccounts> GetAccounts()
            {
                return accounts;
            }
        }

    }
}

