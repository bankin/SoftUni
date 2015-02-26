using System;
using System.Collections.Generic;
using TheatresManagement.Exceptions;
using TheatresManagement.Interfaces;

namespace TheatresManagement
{
    public class TheatreDatabase : IPerformanceDatabase
    {
        private readonly SortedDictionary<string, SortedSet<TheatrePerformace>> _theatresPerformaces;

        public TheatreDatabase()
        {
            this._theatresPerformaces = new SortedDictionary<string, SortedSet<TheatrePerformace>>();   
        }
        
        public void AddTheatre(string theatre)
        {
            if (this._theatresPerformaces.ContainsKey(theatre))
            {
                throw new DuplicateTheatreException("Duplicate theatre");
            }

            this._theatresPerformaces[theatre] = new SortedSet<TheatrePerformace>();
        }

        public IEnumerable<string> ListTheatres()
        {
            return this._theatresPerformaces.Keys;
        }

        public void AddPerformance(string theatreName, string performanceName, DateTime startDateTime, TimeSpan duration, decimal price)
        {
            if (!this._theatresPerformaces.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var performances = this._theatresPerformaces[theatreName];


            var endDateTime = startDateTime + duration;
            if (IsOverlapping(performances, startDateTime, endDateTime))
            {
                throw new TimeDurationOverlapException("Time/duration overlap");
            }

            var performance = new TheatrePerformace(theatreName, performanceName, startDateTime, duration, price);
            performances.Add(performance);
        }

        public IEnumerable<TheatrePerformace> ListAllPerformances()
        {
            var theatres = this._theatresPerformaces.Keys;

            var performances = new List<TheatrePerformace>();
            foreach (var theatre in theatres)
            {                
                performances.AddRange(this._theatresPerformaces[theatre]);
            }

            return performances;
        }

        public IEnumerable<TheatrePerformace> ListPerformances(string theatreName)
        {
            if (!this._theatresPerformaces.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }
            return this._theatresPerformaces[theatreName];            
        }

        private static bool IsOverlapping(IEnumerable<TheatrePerformace> performances, DateTime startDateTime, DateTime endDateTime)
        {
            foreach (var performance in performances)
            {
                var performanceStart = performance.StartDateTime;
                var performanceEnd = performance.StartDateTime + performance.Duration;
                
                var check = (performanceStart <= startDateTime && startDateTime <= performanceEnd) || 
                    (performanceStart <= endDateTime && endDateTime <= performanceEnd) || 
                    (startDateTime <= performanceStart && performanceStart <= endDateTime) || 
                    (startDateTime <= performanceEnd && performanceEnd <= endDateTime);

                if (check)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
