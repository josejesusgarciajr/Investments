using System;
using System.Collections.Generic;

namespace Investments.Models
{
    public class ListOfHouse
    {

        public List<HouseInvestment> LOH { get; set; }

        public ListOfHouse()
        {
            LOH = new List<HouseInvestment>();
        }

        public List<HouseInvestment> CalculatePaymentAtDifferentIntrestRates(HouseInvestment house)
        {

            for (int intrestRate = 10; intrestRate >= 1; intrestRate--)
            {
                HouseInvestment x = new HouseInvestment();
                x.Principle = house.PriceOfHouse;
                x.PriceOfHouse = house.PriceOfHouse;
                x.DurationOfLoanInYears = house.DurationOfLoanInYears;

                // new intrest rate
                x.FixedIntrestRate = intrestRate;

                x.CalculateMortgagePayment();
                x.CalculateTotalCostAndPayedIntrest();
    
                LOH.Add(x);
                HouseInvestment e = LOH[LOH.Count - 1];
                Console.WriteLine($"Last item intrestRate: {e.FixedIntrestRate}");
            }

            return LOH;
        }
    }
}
