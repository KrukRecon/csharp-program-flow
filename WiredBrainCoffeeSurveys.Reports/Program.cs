using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculated values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed * 100;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response percentage: {responseRate}%");
            Console.WriteLine($"Unanswered surveys: {unansweredCount}");
            Console.WriteLine($"Overall score: {overallScore}");

            // Logical comparisons
            bool higherCoffeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee score higher than food: {higherCoffeScore}");
            Console.WriteLine($"Customers would recommend us: {customersRecommend}");
            Console.WriteLine($"Hate granola, love cappucino: {noGranolaYesCappucino}");
        }
    }
}
