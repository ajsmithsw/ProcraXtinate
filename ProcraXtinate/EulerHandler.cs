using System;
using Gtk;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide;

namespace ProcraXtinate
{
	public class EulerHandler : CommandHandler
	{
		protected override void Run()
		{
			base.Run();


			IdeApp.ProjectOperations.Execute(IdeApp.ProjectOperations.CurrentSelectedSolution, true);
			System.Diagnostics.Process.Start(RandomEuler());

		}

		protected override void Update(CommandInfo info)
		{
			base.Update(info);
			info.Enabled = true;
		}

		string RandomEuler()
		{
			var rnd = new Random();

			return string.Format("{0}{1}", "https://projecteuler.net/problem=", rnd.Next(1, 598));
		}
	}
}