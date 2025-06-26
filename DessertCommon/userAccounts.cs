using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertCommon
{
    public class userAccounts
    {

        private String _pass = "";
        static String _userName = "";
        public String userName { get; set; }
        public String Pass
        {
            get { return _pass; }
            set
            {
                if (value.Length == 6)
                {
                    _pass = value;
                }
            }
        }
    }
}


