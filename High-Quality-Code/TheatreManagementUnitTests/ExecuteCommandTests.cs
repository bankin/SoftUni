using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheatresManagement;
using TheatresManagement.Exceptions;

namespace TheatreManagementUnitTests
{
    [TestClass]
    public class ExecuteCommandTests
    {
        private const string TheatreName = "Theare";

        [TestMethod]
        public void PrintAllTheatersWhenEmpty()
        {
            Assert.AreEqual(ExecuteCommand.PrintAllTheatres(), "No theatres");
        }

        [TestMethod]
        public void PrintAllPerformancesWhenNoneAvailable()
        {
            Assert.AreEqual(ExecuteCommand.PrintAllPerformances(), "No performances");
        }

        [TestMethod]
        public void AddTheatre()
        {
            Assert.AreEqual(ExecuteCommand.AddTheatre(TheatreName), "Theatre added");
        }

        [TestMethod]
        public void PrintAllTheatersOneAvailable()
        {            
            Assert.AreEqual(ExecuteCommand.PrintAllTheatres(), TheatreName);
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateTheatreException), "Duplicate theatre")]
        public void AddTheatreTwice()
        {
            ExecuteCommand.AddTheatre(TheatreName);
            ExecuteCommand.AddTheatre(TheatreName);
        }

        [TestMethod]
        public void PrintAllTheatersManyAvailable()
        {
            ExecuteCommand.AddTheatre("0");
            ExecuteCommand.AddTheatre("1");
            ExecuteCommand.AddTheatre("2");
            Assert.AreEqual(ExecuteCommand.PrintAllTheatres(), "0, 1, 2, "+TheatreName);
        }

        [TestMethod]
        public void PrintAllTheatersManyAvailableSortedByName()
        {
            ExecuteCommand.AddTheatre("z");
            ExecuteCommand.AddTheatre("a");
            ExecuteCommand.AddTheatre("c");
            Assert.AreEqual(ExecuteCommand.PrintAllTheatres(), "0, 1, 2, a, c, " + TheatreName + ", z");
        }

        [TestMethod]
        public void AddPerformance()
        {
            Assert.AreEqual("Performance added", ExecuteCommand.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m));
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException), "Time/duration overlap")]        
        public void AddOverlapingPerformance()
        {
           ExecuteCommand.AddPerformance(TheatreName, "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException), "Theatre does not exist")]
        public void AddPerformanceToInvalidTheatre()
        {
            ExecuteCommand.AddPerformance("123", "perf1", new DateTime(2013, 10, 12, 20, 20, 12), new TimeSpan(0, 2, 30, 10), 20.3m);
        }

        [TestMethod]
        public void PrintPerformanceForTheatre()
        {
            Assert.AreEqual("(perf1, " + new DateTime(2013, 10, 12, 20, 20, 12).ToString("dd.MM.yyyy HH:mm")  + ")", 
                ExecuteCommand.PrintPerformances(TheatreName));
        }

        [TestMethod]
        public void PrintPerformanceForTheatreNoPerformance()
        {
            Assert.AreEqual("No performances", ExecuteCommand.PrintPerformances("1"));
        }

        [TestMethod]
        public void PrintAllPerformances()
        {
            string expected = "(perf1, Theare, 12.10.2013 20:20)";
            Assert.AreEqual(ExecuteCommand.PrintAllPerformances(), expected);
        }
    }
}
