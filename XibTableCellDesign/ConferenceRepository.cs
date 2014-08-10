using System;
using System.Collections.Generic;
using System.Linq;

namespace XibTableCellDesign
{

	public static class ConferenceRepository
	{
		public static List<Conference> GetConferences()
		{
			var conferences = new List<Conference> 
			{ 
				new Conference 
				{
					Name = "Evolve", 
					StartDate = new DateTime (2014, 08, 06),
					Description = @"Join Xamarin along with over a thousand top mobile developers this October in Atlanta for the cross-platform mobile development event of the year. Learn from industry leaders and Xamarin experts to advance your career and mobile projects."
				},
				new Conference 
				{
					Name = "WWDC", 
					StartDate = new DateTime (2014, 06, 02),
					Description = @"Get an in-depth look at what’s next in iOS and OS X, and learn how to take your apps to the next level. With over 100 sessions, extensive hands–on labs, and engaging events, you’ll connect with Apple engineers and fellow developers for an incredible week of inspiration."
				},
				new Conference 
				{
					Name = "Google I/O", 
					StartDate = new DateTime (2014, 06, 25),
					Description = @"Learn the tech world's latest web, mobile and social breakthroughs and meet the developers who are turning them into tomorrow's startups. Keep yourself and your team driving innovation at Google I/O."
				},
				new Conference 
				{
					Name = "Build", 
					StartDate = new DateTime (2014, 04, 02),
					Description = @"At Build, we’ll share updates and talk about what’s next for Windows, Windows Server, Windows Azure, Visual Studio and more. Build is the path to creating and implementing your great ideas, and then differentiating them in the market."
				},
			};

			return conferences.OrderBy(c => c.StartDate).ToList();
		}
	}
}