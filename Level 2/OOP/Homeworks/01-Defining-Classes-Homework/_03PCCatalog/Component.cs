using System;


namespace _03PCCatalog
{
	public class Component
	{
		private string type;
		private string name;
		private string details;
		private decimal price;

		public Component (string type, string name, decimal price, string details = null)
		{
			this.Type = type;
			this.Name = name;
			this.Details = details;
			this.Price = price;
		}

		public string Type {
			get {
				return type;
			}
			set {
				ValidationMethods.ValidateValue (value, "Component Type");
				this.type = value;
			}
		}

		public string Name {
			get {
				return name;
			}
			set {
				ValidationMethods.ValidateValue (value, "Component Name");
				this.name = value;
			}
		}

		public string Details {
			get {
				return details;
			}
			set {
				ValidationMethods.ValidateValue (value, "Component Details");
				this.details = value;
			}
		}

		public decimal Price {
			get {
				return price;
			}
			set {
				ValidationMethods.ValidateValue (value, "Component Price");
				this.price = value;
			}
		}
	}
}

