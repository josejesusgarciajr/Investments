using System;
using System.Collections.Generic;

namespace Investments.Models
{
    public class Investment
    {
        private double Percentage = 0.06;

        public double MoneyInvested { get; set; }
        public double MonthlyContribution { get; set; }
        public double MoneyContributionToDate { get; set; }

        public int NumMonths { get; set; }
        public double NetProfit { get; set; }

        /*
         * testing list of MonthlyIRData
         */
        public List<MonthlyIRData> MonthlyIRDatas { get; set; }

        public Investment()
        {
        }

        public List<MonthlyIRData> CalculateReturns()
        {
            MonthlyIRDatas = new List<MonthlyIRData>();

            double moneyMoved = MoneyInvested;
            MoneyContributionToDate = MoneyInvested;

            for (int month = 0; month < NumMonths; month++)
            {
                double x = MonthlyReturn(moneyMoved);
                MoneyContributionToDate += MonthlyContribution;

                MonthlyIRDatas.Add(new MonthlyIRData(MoneyContributionToDate, x - moneyMoved - MonthlyContribution, x));
                moneyMoved = x;
            }
            return MonthlyIRDatas;
        }

        public double MonthlyReturn(double money)
        {
            double YearlyReturn = (money + MonthlyContribution) * Percentage;
            double ThisMonthsReturn = YearlyReturn / 12;

            NetProfit += ThisMonthsReturn;

            return ThisMonthsReturn + (money + MonthlyContribution);
        }
    }
}
