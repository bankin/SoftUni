using System;
using System.Linq;
using System.Text;
using TheatresManagement.Interfaces;

namespace TheatresManagement
{
    public static class ExecuteCommand
    {
        private static readonly IPerformanceDatabase TheatreDatabase = new TheatreDatabase();

        public static string AddTheatre(string theatreName)
        {
            TheatreDatabase.AddTheatre(theatreName);
            return "Theatre added";
        }

        //Bottleneck: The ListTheatres method gives you the theater names no need to do anything else - like adding and removing from lists.
        public static string PrintAllTheatres()
        {
            var theatres = TheatreDatabase.ListTheatres();
            if (theatres.Any())
            {
                return String.Join(", ", theatres);
            }

            return "No theatres";
        }

        public static string AddPerformance(string theatreName, string performanceName, DateTime startDateTime, TimeSpan duration, decimal price)
        {
            TheatreDatabase.AddPerformance(theatreName, performanceName, startDateTime, duration, price);
            return "Performance added";;
        }

        //Bottleneck: TheatrePerformance has ToString method - use it! No need to do time consuming toString operations.
        public static string PrintAllPerformances()
        {
            var performances = TheatreDatabase.ListAllPerformances().ToList();
            var resultStringBuilder = new StringBuilder();
            if (performances.Any())
            {
                for (int i = 0; i < performances.Count; i++)
                {
                    resultStringBuilder.Append(performances[i]);
                    if (i < performances.Count - 1)
                    {
                        resultStringBuilder.Append(", ");
                    }
                }
                return resultStringBuilder.ToString();
            }

            return "No performances";
        }

        public static string PrintPerformances(string theatre)
        {
            var performances = TheatreDatabase.ListPerformances(theatre).Select(p =>
            {
                string result1 = p.StartDateTime.ToString("dd.MM.yyyy HH:mm");
                return string.Format("({0}, {1})", p.PerformanceName, result1);
            }).ToList();

            return performances.Any() ? string.Join(", ", performances) : "No performances";
        }
    }
}