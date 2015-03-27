using System;
using System.Collections.Generic;
using System.Text;

namespace _03PCCatalog
{
	public class Computer
	{
		private string name;
		private Dictionary<string, Component> components = new Dictionary<string, Component> ();
		private decimal price;


//		Constructors
		public Computer(string name)
		{
			this.Name = name;
		}
		public Computer (string name, params Component[] components)
			: this(name: name)
		{
			foreach (var component in components) {
				this.Components.Add (component.Type, component);
				this.Price += component.Price;
			}
		}


//		Properties
		public string Name {
			get {
				return this.name;
			}
			set {
				ValidationMethods.ValidateValue (value, "Computer Name");
				this.name = value;
			}
		}
		public decimal Price {
			get {
				return this.price;
			}
			set {
				this.price = value;  //validation is done within the Component class
			}
		}
		public Dictionary<string, Component> Components {
			get {
				return this.components;
			}
			set {
				this.components = Components;  //validation is done within the Component class
			}
		}
		public override string ToString ()
		{
			return String.Format (this.name + "\n" + ComponentDescription(components) + 
			                      "Total Price: " + this.price.ToString("F") + " лв.");
		}


		// a method that returns a single string with all laptop components
		private string ComponentDescription(Dictionary<string, Component> parameters)
		{
			StringBuilder output = new StringBuilder ();
			foreach (var pair in parameters) {
				if (pair.Key != null) {
					output.AppendLine(pair.Key + ": " + 
					                  "Name - " + pair.Value.Name + ", Price - " + pair.Value.Price.ToString("F") + 
					                  " лв., Details - " + (pair.Value.Details ?? "N/A") + ";");
				}
			}
			return output.ToString();
		}


		// this method displays information about a particular component if such exists.
		// Example: computer1.GetComponentByName("Processor");
		public string GetComponentByName(string name)
		{
			if (this.components.ContainsKey(name)) {
				return (name + ": " + 
				        "Name - " + this.components[name].Name + ", Price - " + this.components[name].Price.ToString("F") + 
				        " лв., Details - " + (this.components[name].Details ?? "N/A") + ";");
			}
			return "The component \'" + name + "\' does not exist!" ;
		}


		// this method can add more components to a computer
		public void AddComponent(Component component)
		{
			this.Components.Add (component.Type, component);
			this.Price += component.Price;
		}


		// this method can replace a component
		public void ReplaceComponent(string name, Component newComponent)
		{
			this.Price -= this.Components [name].Price;
			this.Components [name] = newComponent;
			this.Price += newComponent.Price;
		}

		// this method can remove a component
		public void RemoveComponent(string name)
		{
			this.Price += this.Components[name].Price;
			this.Components.Remove (name);
		}
	}
}

