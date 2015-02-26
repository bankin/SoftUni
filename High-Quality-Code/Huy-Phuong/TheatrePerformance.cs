using System;

namespace TheatresManagement
{
    public class TheatrePerformace : IComparable<TheatrePerformace>
    {
        public TheatrePerformace(string theatreName, string performanceName, DateTime startDateTime, TimeSpan duration, decimal price)
        {
            this.TheatreName = theatreName;
            this.PerformanceName = performanceName;
            this.StartDateTime = startDateTime;
            this.Duration = duration;
            this.Price = price;
        }

        public string TheatreName { get; protected internal set; }
        public string PerformanceName { get; private set; }
        public DateTime StartDateTime { get; set; }
        public TimeSpan Duration { get; private set; }
        public decimal Price { get; protected set; }

        int IComparable<TheatrePerformace>.CompareTo(TheatrePerformace otherTheatrePerformace)
        {
            return this.StartDateTime.CompareTo(otherTheatrePerformace.StartDateTime);
        }

        public override string ToString()
        {
            string result = string.Format("({0}, {1}, {2})",
                this.PerformanceName,                
                this.TheatreName,
                this.StartDateTime.ToString("dd.MM.yyyy HH:mm"));
            return result;
        }
    }
}
