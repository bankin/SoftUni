using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    class NightlifeEngine : CinemaEngine
    {

        private string reportFormat = "{0}: {1} ticket(s), total: ${2:0.00}\nVenue: {3} ({4})\nStart time: {5}\n";

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    var cinema = new Cinema(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(cinema);
                    break;
                case "opera":
                    var opera = new Opera(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concertHall);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "movie":
                    var venue = this.GetVenue(commandWords[5]);
                    var movie = new Movie(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(movie);
                    break;
                case "theatre":
                    venue = this.GetVenue(commandWords[5]);
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    venue = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }

                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;

                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteSellTicketCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);            
            var type = (TicketType)Enum.Parse(typeof(TicketType), commandWords[2], true);
            base.Output.Append(performance.SellTicket(type));
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);

            base.Output.Append(getReportForPerformance(performance as Performance));
        }

        private string getReportForPerformance(Performance performance)
        {

            var ticketsSold = performance.Tickets.Where(t => t.Status == TicketStatus.Sold);
            decimal totalPrice = 0.0m;
            foreach (var ticket in ticketsSold)
            {
                totalPrice += ticket.Price;
            }
            return string.Format(reportFormat, performance.Name, ticketsSold.Count(), totalPrice, performance.Venue.Name,
                performance.Venue.Location, performance.StartTime);
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            var performances = this.Performances.Where(p => p.Name.ToUpper().Contains(commandWords[1].ToUpper().Trim()) && p.StartTime >= DateTime.Parse(commandWords[2])).ToList();
            if (commandWords.Length > 2)
            {
                performances =
                    this.Performances.Where(
                        p =>
                            p.Name.ToUpper().Contains(commandWords[1].ToUpper().Trim()) &&
                            p.StartTime >= DateTime.Parse(commandWords[2]) &&
                            p.StartTime <= DateTime.Parse(commandWords[3])).ToList();
            }
            

            performances.Sort(delegate(IPerformance p1, IPerformance p2) {
                if (p1.StartTime.Equals(p2.StartTime))
                {
                    if (p1.BasePrice.Equals(p2.BasePrice))
                    {
                        return p1.Name.CompareTo(p2.Name);
                    }
                    return p2.BasePrice.CompareTo(p1.BasePrice);
                }
                return p1.StartTime.CompareTo(p2.StartTime);
            });
            base.Output.Append(string.Format("Search for \"{0}\"\n", commandWords[1]));
            base.Output.Append("Performances:\n");
            if (performances.Count == 0)
            {
                base.Output.Append("no results\n");
            }
            else
            {
                foreach (var performance in performances)
                {
                    base.Output.Append("-" + performance.Name + "\n");
                }    
            }

            base.Output.Append("Venues:\n");
            var venues = this.Venues.Where(v => v.Name.ToUpper().Contains(commandWords[1].ToUpper().Trim())).ToList();

            venues.OrderBy(v => v.Name);
            
            if (venues.Count == 0)
            {
                base.Output.Append("no results\n");
            }
            else
            {
                
                foreach (var venue in venues)
                {
                    base.Output.Append("-" + venue.Name + "\n");
                    var events = this.Performances.Where(p => p.Venue.Name.Equals(venue.Name) && p.StartTime >= DateTime.Parse(commandWords[2]) && p.StartTime <= DateTime.Parse(commandWords[3])).ToList();
                    if (commandWords.Length > 2)
                    {
                        events =
                            this.Performances.Where(
                                p =>
                                    p.Venue.Name.Equals(venue.Name) &&
                                    p.StartTime >= DateTime.Parse(commandWords[2]) &&
                                    p.StartTime <= DateTime.Parse(commandWords[3])).ToList();
                    }
                    events.Sort(delegate(IPerformance p1, IPerformance p2)
                    {
                        if (p1.StartTime.Equals(p2.StartTime))
                        {
                            if (p1.BasePrice.Equals(p2.BasePrice))
                            {
                                return p1.Name.CompareTo(p2.Name);
                            }
                            return p2.BasePrice.CompareTo(p1.BasePrice);
                        }
                        return p1.StartTime.CompareTo(p2.StartTime);
                        
                    });

                    foreach (var ev in events)
                    {
                        base.Output.Append("--" + ev.Name + "\n");
                    }
                }
            }
        }
    }
}
