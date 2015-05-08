using System;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03PCCatalog
{
	class Catalog
	{
		public static void Main (string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

			Computer lowRangeComp = 
				new Computer ("Cheapatron 1A88", new Component("Processor", "Intel® Pentium®", 120m), 
                              new Component("Motherboard", "MSI H81M-P33", 50m, "Socket 1150 VGA DVI 8 Channel Audio mATX"), 
                              new Component("RAM", "Crucial", 40m, "4GB DDR3" ));

			Computer midRangeComp = 
				new Computer ("Pleaser HCZ", new Component("Processor", "Intel® Core™ i3", 250m), 
                              new Component("Motherboard", "ASUS Z97-K", 120m), 
                              new Component("RAM", "Corsair", 85m, "8GB DDR3" ));

			Computer topRangeComp = 
				new Computer ("Performer i20", new Component("Processor", "Intel® Core™ i5", 350.5m), 
				              new Component("Motherboard", "MSI X99S GAMING", 300m), 
				              new Component("RAM", "Corsair", 150m, "2x8GB DDR3"), 
				              new Component("Video", "EVGA GeForce GTX 750Ti", 220m));

			Computer emptyComp = new Computer ("Empty Computer");
//			New components can be added, removed or replaced with:
//			AddComponent(Component component), ReplaceComponent(string name, Component newComponent), 
//			RemoveComponent(string name)

			List<Computer> computersList = new List<Computer> () { midRangeComp, lowRangeComp, topRangeComp, emptyComp };
			foreach (var comp in computersList.OrderBy(x => x.Price)) {
				Console.WriteLine (comp);
				Console.WriteLine ("-------------------------");
			}

			Console.WriteLine ("Current Processor of \'Performer i20\' is:\n" + topRangeComp.GetComponentByName("Processor"));
			topRangeComp.ReplaceComponent ("Processor", new Component ("Processor", "Intel® Core™ i7", 550m));
			Console.WriteLine ("Changed Processor of Performer i20. New computer description is:\n" + topRangeComp);
		}
	}
}
