using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeSurveys.Reports
{
    public static class Q1Results
    {
        // Aggregate ratings
        public static double ServiceScore { get; set; } = 8.0;

        public static double CoffeeScore { get; set; } = 4.0;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cappucino";

        public static string LeastFavoriteProduct { get; set; } = "Granola";
        
        public static string AreaToImprove { get; set; } = "MobileApp";

        // Aggregate counts
        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;

        // Individual survey responses
        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "test1@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 7.0,
                FoodScore = 9.0,
                WouldRecommend = 8.0,
                FavoriteProduct = "Latte",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "MobileApp",
                Comments = "Coffee and service are great!",
            },
            new SurveyResponse()
            {
                EmailAddress = "test2@sample.com",
                ServiceScore = 7.5,
                CoffeeScore = 10.0,
                PriceScore = 7.0,
                FoodScore = 6.0,
                WouldRecommend = 8.0,
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "MobileApp",
                Comments = "The mobile app looks bad on Android devices",
            },
            new SurveyResponse()
            {
                EmailAddress = "test3@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 6.5,
                FoodScore = 7.0,
                WouldRecommend = 8.0,
                FavoriteProduct = "Americano",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "Cleanliness",
                Comments = "Overall i had a great experience, I like the store design",
            },
            new SurveyResponse()
            {
                EmailAddress = "test4@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 9.0,
                PriceScore = 7.5,
                FoodScore = 5.0,
                WouldRecommend = 4.0,
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "Pricing",
                Comments = "The pickup area shoul be by the door. Also Your prices are much too high",
            },
            new SurveyResponse()
            {
                EmailAddress = "test5@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 6.5,
                FoodScore = 7.0,
                WouldRecommend = 6.0,
                FavoriteProduct = "Iced Coffee",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "Other",
                Comments = "I like the store but your coffee is too expensive",
            },
            new SurveyResponse()
            {
                EmailAddress = "test6@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 6.5,
                FoodScore = 7.0,
                WouldRecommend = 7.5,
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "MobileApp",
                Comments = "Your staff are very friendly but your mobile app is too slow",
            },
            new SurveyResponse()
            {
                EmailAddress = "test7@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 6.5,
                FoodScore = 7.0,
                WouldRecommend = 7.5,
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "MobileApp",
                Comments = "The mobile app doesn't work on tablets",
            },
            new SurveyResponse()
            {
                EmailAddress = "test8@sample.com",
                ServiceScore = 8.5,
                CoffeeScore = 8.0,
                PriceScore = 6.5,
                FoodScore = 7.0,
                WouldRecommend = 6.5,
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                AreaToImprove = "MobileApp",
                Comments = "So close to recommending but your prices are so high",
            },
        };
    }
}
