using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_House_of_Coffee
{
	public static class EnumUtil
	{
		public static IEnumerable<T> GetValue<T>()
		{
			return Enum.GetValues(typeof(T)).Cast<T>();
		}
	}

	class GetProfits
	{
		double totalCoffeeProfit;
		double totalSandwichesProfit;
		double totalGoodsProfit;

		public GetProfits()
		{
			int units = 0;
			var sizesValues = EnumUtil.GetValue<Coffee>();

			foreach (var Coffee in sizesValues)
			{
				Console.WriteLine($"Please enter the number of {Coffee} coffees sold ");

				try
				{
					units = int.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine($"Please re-enter the number of {Coffee} coffees sold");
					units = int.Parse(Console.ReadLine());
				}

				Console.Write($"Total from {Coffee} coffee sales is $");
				DoMath Coffees = new DoMath (Coffee, units);
				totalCoffeeProfit += Coffees.Profit();
			}

			Console.WriteLine($"Your total coffee profits are ${totalCoffeeProfit}\n");

			var sandwichValues = EnumUtil.GetValue<Sandwiches>();

			foreach (var sandwhich in sandwichValues)
			{
				Console.WriteLine($"Please enter the number of {sandwhich} sandwiches sold");

				try
				{
					units = int.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine($"Please re-enter the number of {sandwhich} sandwhiches sold");
					units = int.Parse(Console.ReadLine());
				}
				Console.Write($"Total from {sandwhich} sandwich sales is $");
				DoMath sandwichs = new DoMath (sandwhich, units);
				totalSandwichesProfit += sandwichs.Profit();
			}

			Console.WriteLine($"Your total sandwich profits are ${totalSandwichesProfit}\n");

			totalGoodsProfit = (totalCoffeeProfit) + totalSandwichesProfit;
			Console.WriteLine($"Your total goods profits for today is ${totalGoodsProfit}\n");
			Console.WriteLine("press enter to go to the main menus \n");
			Console.ReadLine();
			Console.Clear();
			UI goBack = new UI();
		}
	}
}
