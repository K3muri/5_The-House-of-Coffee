using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_House_of_Coffee
{
	public enum Coffee
	{
		Small,
		Medium,
		Large,
	}

	public enum Sandwiches
	{
		EggSandwich,
	    ChickenBiscuit
	}

	public class PriceandCost
	{
		public double[] coffeeprice     = {1.00, 3.00, 5.00};
		public double[] coffeecost      = {0.10, 0.15, 0.20};

		public double[] sandwichesprice = {5.50, 7.50};
		public double[] sandwichescost  = {0.95, 1.20};
	}
}
