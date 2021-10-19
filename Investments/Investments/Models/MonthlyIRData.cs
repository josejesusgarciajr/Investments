using System;
namespace Investments.Models
{
    public class MonthlyIRData
    {

        public double Money { get; set; }
        public double MonthlyProfit { get; set; }
        public double MoneyContribution { get; set; }

        public MonthlyIRData(){}

        public MonthlyIRData(double moneyContribution, double monthlyProfit, double money)
        {
            MoneyContribution = moneyContribution;
            MonthlyProfit = monthlyProfit;
            Money = money;
        }
    }
}
