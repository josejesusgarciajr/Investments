using System;
using System.Collections.Generic;

namespace Investments.Models
{
    public class Client
    {

        /*
         * Client Information
         */

        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }

        /*
         * Client's Inventments
         *  - House's
         *  - Stock Market
         */
        public Investment StockInvestment { get; set; }

        public Client()
        {
        }
    }
}
