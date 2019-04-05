using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_House_of_Coffee
{

	public struct DoMath
	{ 	
		double costs, price, units;

		public DoMath(Coffee size, int numOfSales)
		{
			PriceandCost CoffeeData = new PriceandCost();
			costs = CoffeeData.coffeecost [(int)size];
			price = CoffeeData.coffeeprice[(int)size];
			units = numOfSales;
		}

		public DoMath(Sandwiches sandwich, int numOfSales)
		{
			PriceandCost SandwichesData = new PriceandCost();
			costs = SandwichesData.sandwichescost [(int)sandwich];
			price = SandwichesData.sandwichesprice[(int)sandwich];
			units = numOfSales;
		}

		public double Profit()
		{
			double SaleTotal = price * units;
			Console.WriteLine($"{SaleTotal}");

			double CostTotal = costs * units;
			Console.WriteLine($"your costs is ${CostTotal}");

			double profitTotal = (price - costs) * units;
			Console.WriteLine($"your profit is ${profitTotal}\n");

			return SaleTotal;
		}
	}
}
