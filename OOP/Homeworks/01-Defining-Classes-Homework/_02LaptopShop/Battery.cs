using System;

namespace _02LaptopShop
{
	public class Battery
	{
		private string type;
		private float? life;
		public Battery (string type = null, float? life = null)
		{
			this.Type = type;
			this.Life = life;
		}
		public string Type {
			get { return this.type; }
			set 
			{
				ValidationMethods.ValidateValue (value, "Battery Type");
				this.type = value;
			}
		}
		public float? Life {
			get { return this.life; }
			set
			{
				ValidationMethods.ValidateValue (value, "Battery Life");
				this.life = value;
			}
		}
	}
}

