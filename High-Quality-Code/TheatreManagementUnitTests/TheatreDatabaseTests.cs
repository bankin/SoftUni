using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheatresManagement;
using TheatresManagement.Exceptions;

namespace TheatreManagementUnitTests
{
    [TestClass]
    public class TheatreDatabaseTests
    {
        private const string TheatreName = "new theatre";
        [TestMethod]
        public void ConstructAnEmptyObject()
        {
            var theatreDatabase = new TheatreDatabase();
            Assert.IsTrue(theatreDatabase != null);
        }

        [TestMethod]
        public void ConstructAnEmptyObjectCheckCollectionEmpty()
        {
            var theatreDatabase = new TheatreDatabase();
            Assert.AreEqual(0, theatreDatabase.ListTheatres().Count());
        }

        [TestMethod]
        public void AddOneTheatreAndListIt()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            Assert.AreEqual(TheatreName, theatreDatabase.ListTheatres().ToArray()[0]);
        }

        [TestMethod]
        public void AddOneTheatreAndCheckCollectionLength()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            Assert.AreEqual(1, theatreDatabase.ListTheatres().Count());
        }

        [TestMethod]
        public void AddMilionTheatresAndCheckCollectionLength()
        {
            var theatreDatabase = new TheatreDatabase();
            int size = 1000000;
            for (int i = 0; i < size; i++)
            {
                theatreDatabase.AddTheatre(TheatreName + i);
            }
            Assert.AreEqual(size, theatreDatabase.ListTheatres().Count());
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateTheatreException), "Duplicate Theatre")]
        public void AddATheatreTwoTimes()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddTheatre(TheatreName);
        }

        [TestMethod]
        public void AddPerformanceAndCheckCollectionCount()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().Count(), 1);
        }

        [TestMethod]
        public void AddPerformanceAndCheckTheatreName()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().ToList()[0].TheatreName, TheatreName);
        }

        [TestMethod]
        public void AddPerformanceAndCheckPerformanceName()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().ToList()[0].PerformanceName, "perf1");
        }

        [TestMethod]
        public void AddPerformanceAndCheckStartDateTime()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().ToList()[0].StartDateTime, new DateTime(2013, 10, 12, 20, 20, 12));
        }

        [TestMethod]
        public void AddPerformanceAndCheckDuration()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().ToList()[0].Duration, new TimeSpan(0, 2, 30, 10));
        }

        [TestMethod]
        public void AddPerformanceAndCheckTicketPrice()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            Assert.AreEqual(theatreDatabase.ListAllPerformances().ToList()[0].Price, 20.3m);
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException), "Theatre does not exist")]
        public void AddPerformanceToInvalidTheatre()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre("asd");
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);            
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException), "Time/duration overlap")]
        public void AddPerformancesWithOverlapping()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 0), new TimeSpan(0, 2, 40, 0), 20.3m);
            theatreDatabase.AddPerformance(TheatreName, "perf2", new DateTime(2013, 10, 12, 20, 21, 0), new TimeSpan(0, 2, 30, 10), 20.3m);
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException), "Time/duration overlap")]
        public void AddPerformancesSecondStartsAtForstEnd()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 0), new TimeSpan(0, 2, 40, 0), 20.3m);
            theatreDatabase.AddPerformance(TheatreName, "perf2", new DateTime(2013, 10, 12, 23, 0, 0), new TimeSpan(0, 2, 30, 10), 20.3m);
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException), "Time/duration overlap")]
        public void AddPerformancesSecondEndAtFirstStart()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 0), new TimeSpan(0, 2, 40, 0), 20.3m);
            theatreDatabase.AddPerformance(TheatreName, "perf2", new DateTime(2013, 10, 12, 20, 0, 0), new TimeSpan(0, 0, 20, 0), 20.3m);
        }

        [TestMethod]
        public void ListAddedPerformancesForTheatreCheckCollectionCount()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddTheatre("asd");
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 0), new TimeSpan(0, 2, 40, 0), 20.3m);
            theatreDatabase.AddPerformance("asd", "perf2", new DateTime(2013, 10, 12, 23, 0, 0), new TimeSpan(0, 2, 30, 10), 20.3m);
            theatreDatabase.AddPerformance(TheatreName, "perf2", new DateTime(2013, 10, 12, 10, 0, 0), new TimeSpan(0, 2, 30, 10), 20.3m);
            
            Assert.AreEqual(2, theatreDatabase.ListPerformances(TheatreName).Count());
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException), "Theatre does not exist")]
        public void ListPerformancesForNotExistingTheatre()
        {
            var theatreDatabase = new TheatreDatabase();
            theatreDatabase.AddTheatre(TheatreName);
            theatreDatabase.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
            theatreDatabase.ListPerformances("asd");
        }

    }
}
