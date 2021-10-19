using System;
namespace Investments.Models
{
    public class HouseInvestment
    {
        /*
         * Initial House Information
         */
        public double PriceOfHouse { get; set; }
        public double DownPayment { get; set; }

        /*
         * Personal Information needed to Calculate Mortage Monthly Payment
         */
        public int CreditScore { get; set; }

        /*
         * Mortgage Information
         *  - This information is calculated given the information above
         *     1. Price of House
         *     2. Down Payment
         *     3. Credit Score
         */
        public double Mortgage { get; set; }
        public double MortgageMonthlyPayment { get; set; }
        public int MonthsLeftToPay { get; set; }

        /*
         * Rent Paid By Tenent
         */
        public double RentPrayment { get; set; }

        public HouseInvestment()
        {
        }
    }
}
