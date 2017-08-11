using System;
using Gtk;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide;

namespace ProcraXtinate
{
	public class BuildHandler : CommandHandler
	{
		protected override void Run()
		{
			base.Run();

			System.Diagnostics.Process.Start(RandomWebsite());
			IdeApp.ProjectOperations.Execute(IdeApp.ProjectOperations.CurrentSelectedSolution, true);
		}

		protected override void Update(CommandInfo info)
		{
			base.Update(info);
			info.Enabled = true;
		}

		string RandomWebsite()
		{
			var websites = new string[] 
			{
				"http://www.websudoku.com/", 
				"https://news.ycombinator.com/", 
				"https://hackernoon.com/", 
				"https://codefights.com/"
			};

			var rnd = new Random();

			return websites[rnd.Next(0, websites.Length - 1)];
		}
	}
}
