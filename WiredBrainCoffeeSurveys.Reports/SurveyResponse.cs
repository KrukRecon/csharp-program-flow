﻿namespace WiredBrainCoffeeSurveys.Reports
{
    public class SurveyResponse
    {
        public string EmailAddress { get; set; }
        public double ServiceScore { get; set; }
        public double CoffeeScore { get; set; }
        public double PriceScore { get; set; }
        public double FoodScore { get; set; }
        public double WouldRecommend { get; set; }
        public string FavoriteProduct { get; set; }
        public string LeastFavoriteProduct { get; set; }
        public string AreaToImprove { get; set; }
        public string Comments { get; set; }
    }
}