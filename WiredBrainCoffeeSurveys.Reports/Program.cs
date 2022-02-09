using System;
using System.Collections.Generic;
using System.IO;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please specify a report to run (rewards, comments, tasks, quit): ");
                var selectedReport = Console.ReadLine();

                switch (selectedReport)
                {
                    case "rewards":
                        GeneratingWinnerEmails();
                        break;
                    case "comments":
                        GenerateCommentsReport();
                        break;
                    case "tasks":
                        GenerateTasksReport();
                        break;
                    case "quit":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid option");
                        break;
                }
            } while (!quitApp);
        }

        public static void GeneratingWinnerEmails()
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winners Output: ");
            while (selectedEmails.Count < 2 && counter < Q1Results.Responses.Count)
            {
                var currentItem = Q1Results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }

            File.WriteAllLines("WinnersReport.csv", selectedEmails);
        }

        public static void GenerateCommentsReport()
        {
            var comments = new List<string>();

            Console.WriteLine(Environment.NewLine + "Comments output: ");
            for (int i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];

                if (currentResponse.WouldRecommend < 7)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }
            }

            foreach (var response in Q1Results.Responses)
            {
                if (response.AreaToImprove == Q1Results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Add(response.Comments);
                }
            }

            File.WriteAllLines("CommentsReport.csv", comments);
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

            Console.WriteLine(Environment.NewLine + "Tasks output: ");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            File.WriteAllLines("TasksReport.csv", tasks);
        }
    }
}
