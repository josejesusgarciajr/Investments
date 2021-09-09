using System;
namespace Investments.Models
{
    public class MonthlyIRData
    {

        public double Money { get; set; }
        public double MonthlyProfit { get; set; }

        public MonthlyIRData(){}

        public MonthlyIRData(double money, double monthlyProfit)
        {
            Money = money;
            MonthlyProfit = monthlyProfit;
        }
    }
}
