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

			var websites = new string[] {"http://www.websudoku.com/", "https://news.ycombinator.com/", "https://hackernoon.com/", "https://codefights.com/"};
			var rnd = new Random();
			System.Diagnostics.Process.Start(websites[rnd.Next(0, 3)]);

			IdeApp.ProjectOperations.Build(IdeApp.ProjectOperations.CurrentSelectedSolution);
		}

		protected override void Update(CommandInfo info)
		{
			base.Update(info);
			info.Enabled = true;
		}
	}
}
