using System;
using System.Collections.Generic;
using System.Text;

namespace _02LaptopShop
{
	public class Laptop
	{
		private string model;
		private decimal price;
		private string manufacturer;
		private string processor;
		private string ram;
		private string graphics;
		private string hdd;
		private string screen;
		private Battery battery;
		Dictionary<string, object> laptopParameters = new Dictionary<string, object>();

//		Constructors
		public Laptop(string model, decimal price)
		{
			this.Model = model;
			this.Price = price;
		}

		public Laptop(string model, decimal price, string manufacturer = null, string processor = null, 
		              string ram = null, string graphics = null, string hdd = null, string screen = null, 
		              string battery = null, float? batteryLife = null) 
			: this(model: model, price: price)
		{
			this.Manufacturer = manufacturer;
			this.Processor = processor;
			this.RAM = ram;
			this.Graphics = graphics;
			this.HDD = hdd;
			this.Screen = screen;
			this.Battery = new Battery (battery, batteryLife);
		}

//		Properties
		public string Model {
			get { return this.model; }
			set
			{
				ValidationMethods.ValidateValue (value, "Model");
				this.model = value;
				laptopParameters.Add ("Model", value);
			}
		}
		public string Manufacturer {
			get { return this.manufacturer; }
			set
			{
				ValidationMethods.ValidateValue (value, "Manufacturer");
				this.manufacturer = value;
				laptopParameters.Add ("Manufacturer", value);
			}
		}
		public string Processor {
			get { return this.processor; }
			set
			{
				ValidationMethods.ValidateValue (value, "Processor");
				this.processor = value;
				laptopParameters.Add ("Processor", value);
			}
		}
		public string RAM {
			get { return this.ram; }
			set
			{
				ValidationMethods.ValidateValue (value, "RAM");
				this.ram = value;
				laptopParameters.Add ("RAM", value);
			}
		}
		public string Graphics {
			get { return this.graphics; }
			set
			{
				ValidationMethods.ValidateValue (value, "Graphics");
				this.graphics = value;
				laptopParameters.Add ("Graphics", value);
			}
		}
		public string HDD {
			get { return this.hdd; }
			set
			{
				ValidationMethods.ValidateValue (value, "HDD");
				this.hdd = value;
				laptopParameters.Add ("HDD", value);
			}
		}
		public string Screen {
			get { return this.screen; }
			set
			{
				ValidationMethods.ValidateValue (value, "Screen");
				this.screen = value;
				laptopParameters.Add ("Screen", value);
			}
		}
		public Battery Battery {
			get { return this.battery; }
			set
			{
				//validation is done withing the class Battery
				this.battery = value;
				laptopParameters.Add ("Battery", value.Type);
				if (value.Life != null) {
					laptopParameters.Add ("Battery Life", value.Life + " hours");
				}
			}
		}
		public decimal Price {
			get { return this.price; }
			set
			{
				ValidationMethods.ValidateValue (value, "Price");
				this.price = value;
				laptopParameters.Add ("Price", value.ToString("F") + " lv.");
			}
		}

		public override string ToString ()
		{
			return String.Format (LaptopDescription(laptopParameters));
		}

		// a method that returns a single string with all laptop parameters that have a value
		private string LaptopDescription(Dictionary<string, object> parameters)
		{
			StringBuilder output = new StringBuilder ();
			foreach (var pair in parameters) {
				if (pair.Value != null) {
					output.AppendLine(pair.Key + ": " + pair.Value.ToString());
				}
			}
			return output.ToString().TrimEnd();
		}
	}
}

