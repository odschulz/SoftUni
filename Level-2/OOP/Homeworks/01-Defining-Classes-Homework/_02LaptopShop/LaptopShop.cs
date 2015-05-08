using System;

namespace _02LaptopShop
{
	class LaptopShop
	{
		public static void Main (string[] args)
		{
			Laptop laptop1 = new Laptop (model: "Lenovo Yoga 2 Pro", price: 2259.00m, manufacturer: "Lenovo", 
			                             processor: "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 
			                             ram: "8 GB DDR3", graphics: "Intel HD Graphics 4400", hdd: "128GB SSD", 
			                             screen: "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", 
			                             battery: "Li-Ion, 4-cells, 2550 mAh", batteryLife: 4.5f);
			Laptop laptop2 = new Laptop (model: "HP 250 G2", price: 699.00m);
			Laptop laptop3 = new Laptop (model: "ASUS G750JS-T4046D", price: 2369, ram: " 32GB (4x8192MB) DDR 3", 
			                             battery: "8-cells");

			Console.WriteLine (laptop1);
			Console.WriteLine ("-------------------------------------------------------------------");
			Console.WriteLine (laptop2);
			Console.WriteLine ("-------------------------------------------------------------------");
			Console.WriteLine (laptop3);
		}
	}
}
