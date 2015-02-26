using System;
using System.Collections.Generic;
using TheatresManagement.Exceptions;

namespace TheatresManagement.Interfaces
{
    internal interface IPerformanceDatabase
    {
        /// <summary>
        /// Ads a theatre by given name.
        /// </summary>
        /// <param name="theatreName">Theatre name to be added</param>
        /// <exception cref="DuplicateTheatreException">Thrown when trying to add a theatre name that already exists.</exception>        
        void AddTheatre(string theatreName);

        /// <summary>
        /// Lists all theathres from the database
        /// </summary>
        /// <returns>IEnumerable of theatre names or 'No theatres' in case there are no theatres added</returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Adding a performace to the specified theatre with the specified date-and-time, duration and ticket price
        /// </summary>
        /// <param name="theatreName">The name of the theatre where the performace will be held</param>
        /// <param name="performanceTitle">The name of the performance</param>
        /// <param name="startDateTime">Start date and time of the performance</param>
        /// <param name="duration">Duration of the performance</param>
        /// <param name="price">Ticket price for the perormance</param>
        /// <exception cref="TimeDurationOverlapException">If you try to add performance for a theatre that does not exists</exception>
        /// <exception cref="TheatreNotFoundException">If the current event is overlapping with another one held in this theatre</exception>
        void AddPerformance(string theatreName, string performanceTitle, DateTime startDateTime, TimeSpan duration,
            decimal price);

        /// <summary>
        /// Lists all performances accross all theatres in the format (performance, theatre, date-and-time) ordered by theatre and than date-time
        /// </summary>
        /// <returns>IEnumaravble of theatre performances or 'No performances' if none is found</returns>
        IEnumerable<TheatrePerformace> ListAllPerformances();

        /// <summary>
        /// Lists all the performances for given theatre name in the format (performance, date-time), ordered by date
        /// </summary>
        /// <param name="theatreName">The name of the theatre we want to list performances</param>
        /// <returns>IEnumarable of theatre performance</returns>
        /// <exception cref="TheatreNotFoundException">If no theatre is found with the given name</exception>
        IEnumerable<TheatrePerformace> ListPerformances(string theatreName);
    }
}
