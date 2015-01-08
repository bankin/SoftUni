using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            :base(performance, TicketType.Student)
        {
            
        }

        protected override decimal CalculatePrice()
        {
            if (this.Performance == null)
            {
                throw new ArgumentException("The price cannot be calculated because there is no performance for this ticket.");
            }

            return this.Performance.BasePrice * 0.8m;
        }
    }
}
