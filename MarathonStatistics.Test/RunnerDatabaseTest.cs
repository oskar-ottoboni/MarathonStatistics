using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace MarathonStatistics.Test
{
	[TestClass]
	public class RunnerDatabaseTest
	{

		private List<MarathonRecord> testData = new List<MarathonRecord> {
			new MarathonRecord(){Name = "Rachele Cann", Date = new DateTime(2015,05,12), Time = new TimeSpan(3,23,12)},
			new MarathonRecord(){Name = "Rachele Cann", Date = new DateTime(2017,03,10), Time = new TimeSpan(3,53,10)},
			new MarathonRecord(){Name = "Rachele Cann", Date = new DateTime(2016,02,14), Time = new TimeSpan(2,55,43)},
			new MarathonRecord(){Name = "Pablo Pankow", Date = new DateTime(2016,04,17), Time = new TimeSpan(3,10,20)},
			new MarathonRecord(){Name = "Pablo Pankow", Date = new DateTime(2014,05,22), Time = new TimeSpan(3,30,40)},
			new MarathonRecord(){Name = "Troy Vicks", Date = new DateTime(2015,05,12), Time = new TimeSpan(4,04,27)},
			new MarathonRecord(){Name = "Troy Vicks", Date = new DateTime(2016,1,2), Time = new TimeSpan(5,20,21)},
			new MarathonRecord(){Name = "Troy Vicks", Date = new DateTime(2015,04,14), Time = new TimeSpan(4,54,02)},
			new MarathonRecord(){Name = "Troy Vicks", Date = new DateTime(2016,08,09), Time = new TimeSpan(3,40,12)},
			new MarathonRecord(){Name = "Heidy Large", Date = new DateTime(2015,05,02), Time = new TimeSpan(3,05,19)},
			new MarathonRecord(){Name = "Heidy Large", Date = new DateTime(2016,06,22), Time = new TimeSpan(3,12,18)},
			new MarathonRecord(){Name = "Heidy Large", Date = new DateTime(2016,08,13), Time = new TimeSpan(3,21,17)},
			new MarathonRecord(){Name = "Heidy Large", Date = new DateTime(2017,01,02), Time = new TimeSpan(3,42,16)},
			new MarathonRecord(){Name = "Kathryn Padmore", Date = new DateTime(2015,05,12), Time = new TimeSpan(4,02,42)},
			new MarathonRecord(){Name = "Kathryn Padmore", Date = new DateTime(2014,05,02), Time = new TimeSpan(3,33,32)},
			new MarathonRecord(){Name = "Kathryn Padmore", Date = new DateTime(2016,06,22), Time = new TimeSpan(3,41,22)},
			new MarathonRecord(){Name = "Shakira", Date = new DateTime(2015,02,22), Time = new TimeSpan(3,49,00)},
			new MarathonRecord(){Name = "Shakira", Date = new DateTime(2016,07,30), Time = new TimeSpan(3,51,05)},
			new MarathonRecord(){Name = "Rey Burrows", Date = new DateTime(2017,03,24), Time = new TimeSpan(3,01,07)},
			new MarathonRecord(){Name = "Rihanna", Date = new DateTime(2017,02,22), Time = new TimeSpan(4,13,00)},
			new MarathonRecord(){Name = "Rihanna", Date = new DateTime(2017,07,03), Time = new TimeSpan(4,27,05)},
			new MarathonRecord(){Name = "Rihanna", Date = new DateTime(2017,11,02), Time = new TimeSpan(4,22,09)},
			new MarathonRecord(){Name = "Rihanna", Date = new DateTime(2016,07,07), Time = new TimeSpan(4,21,25)},

		};

		private RunnerDatabase runnerDatabase;

		[TestInitialize]
		public void Init(){
			runnerDatabase = new RunnerDatabase(testData);
		}

		[TestCleanup]
		public void Cleanup(){
			runnerDatabase = null;
		}


		[DataTestMethod]
		[DataRow("2017-01-01", "2017-12-31", "Rey Burrows was the fastest on 24 March 2017 with the time 03:01:07")]
		[DataRow("2016-01-01", "2016-12-31", "Rachele Cann was the fastest on 14 February 2016 with the time 02:55:43")]
		[DataRow("2015-01-01", "2015-12-31", "Heidy Large was the fastest on 2 May 2015 with the time 03:05:19")]
		public void GetFastestRunSumaryTest(string from, string to, string expected)
		{
			Assert.AreEqual(expected, runnerDatabase.GetFastestRunSumary(DateTime.Parse(from), DateTime.Parse(to)));
		}

		[DataTestMethod]
		[DataRow("Pablo Pankow", "3:20:30")]
		[DataRow("pablo pankow ", "3:20:30")]
		[DataRow("Heidy Large", "3:20:18")]
		[DataRow("Shakira", "3:50:03")]
		public void GetAvrageTimeForRunnerAsStringTest(string name, string expected)
		{
			Assert.AreEqual(expected, runnerDatabase.GetAvrageTimeForRunnerAsString(name));
		}


		[DataTestMethod]
		[DataRow(2017, "Rihanna ran 3 marathons in 2017")]
		[DataRow(2016, "Troy and Heidy ran 2 marathons in 2016")]
		[DataRow(2015, "Troy ran 2 marathons in 2015")]
		public void GetRunnerWithMostRunsSummaryTest(int year, string expected)
		{
			Assert.AreEqual(expected, runnerDatabase.GetRunnerWithMostRunsSummary(year));
		}

	}
}
