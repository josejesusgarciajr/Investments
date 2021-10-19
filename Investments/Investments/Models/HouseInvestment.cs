using System;
namespace Investments.Models
{
    public class HouseInvestment
    {
        /*
         * Initial House Information
         */
        public double PriceOfHouse { get; set; }
        public double Principle { get; set; }
        public double DownPayment { get; set; }
        public double FixedIntrestRate { get; set; }
        public int DurationOfLoanInYears { get; set; }


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

        /*
         * Calculates the Monthly Mortgage Payment
         */
        public double CalculateMortgagePayment()
        {
            /*
             * -----------------------------
             * p = Principle
             * r = Fixed Intrest Rate
             * n = Total Number of Payments
             * m = Monthly Mortgage Payment
             * -----------------------------
             * 
             *           p * r/100/12
             * m =  -----------------------
             *                           -n
             *      1 - (1 + (r/100/12) )
             * -----------------------------   
             *       
             * 
             * -----------------------------
             */

            /*
             * First:
             *  - Calculate: p * r/100/12
             */
            double top = (Principle * FixedIntrestRate) / 1200 ;

            /*
             * Second:
             *  - Calculate: (1 + r/12)
             */
            double inside = 1 + ( (FixedIntrestRate /100) / 12);

            /*
             * Third:
             * - Calculate: 1 - (inside)^-n
             * 
             * this is the whole bottom part
             */
            double bottom = 1 - Math.Pow(inside, -(DurationOfLoanInYears * 12));

            // Final Calculation to get Monthly Mortage Payment
            MortgageMonthlyPayment = top / bottom;

            return MortgageMonthlyPayment;
        }
    }
}
