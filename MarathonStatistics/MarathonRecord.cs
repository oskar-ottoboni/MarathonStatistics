using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonStatistics
{
	public class  MarathonRecord
	{
		/// <summary>
		/// Name of the runner
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Date of the race
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// The runners finnishing time
		/// </summary>
		public TimeSpan Time { get; set; }

	}
}
