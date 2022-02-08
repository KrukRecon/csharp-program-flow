using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTasksReport();
        }

        public static void GenerateTasksReport()
        {
            var tasks = new List<string>();

            // Calculated values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed * 100;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            // Logical comparisons
            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Investigate coffe recipes and ingredients");
            }

            if (overallScore > 8)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employers for improvement ideas");
            }

            if (responseRate < 33)
            {
                tasks.Add("Research otpions to improve response rate");
            }
            else if (responseRate >= 33 && responseRate < 66)
            {
                tasks.Add("Reward participants with free coffee coupon");
            }
            else
            {
                tasks.Add("Reward participants with discount coffee coupon");
            }

            switch (Q1Results.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deals");
                    break;
                case "Cleanlines":
                    tasks.Add("Contact the cleaning vendor");
                    break;
                case "MobileApp":
                    tasks.Add("Contact consulting firm about app");
                    break;
                default:
                    tasks.Add("Investigate individual comments for ideas");
                    break;
            }
        }
    }
}
