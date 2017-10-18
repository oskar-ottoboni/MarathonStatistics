using System;
using System.Collections.Generic;

namespace MarathonStatistics
{
	public class RunnerDatabase
	{
		public RunnerDatabase(List<MarathonRecord> data)
		{
			dataset = data;
		}
		private List<MarathonRecord> dataset;

		/// <summary>
		/// Get summary of the runner that has the fastest time in a period
		/// </summary>
		/// <param name="from">period start date</param>
		/// <param name="to">period end date</param>
		/// <returns>Runners name, the date and how fast. i.e. Kendra was the fastest on 14 February 2016 with the time 3:55:45</returns>
		public string GetFastestRunSumary(DateTime from, DateTime to)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get the average time for a runner rounded to nearest second
		/// </summary>
		/// <param name="runnerName">The runners full name</param>
		/// <returns>The avrage time as string. i.e. "4:42:12"</returns>
		public string GetAvrageTimeForRunnerAsString(string runnerName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get summary of the runner that ran the most marathons in a specific year. If many has the same number of marathons show all names and separate them with "and"
		/// </summary>
		/// <param name="year">The selected year</param>
		/// <returns>Runners first name, number of marathons and the current year as a string. i.e. "John ran 5 marathons in 2017" </returns>
		public string GetRunnerWithMostRunsSummary(int year)
		{
			throw new NotImplementedException();
		}
	}
}
