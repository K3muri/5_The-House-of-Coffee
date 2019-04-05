using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_House_of_Coffee
{

	public class UI
	{
		public UI()
		{
			OpeningUI();
		}

		public void OpeningUI()
		{
			int n = 0;

			Console.WriteLine("open sales calcuator press 1 \n " +
				              "open employee pay roll press 2 \n" +
				              "exit program press 3");

			try
			{
				n = int.Parse(Console.ReadLine());

				if (n < 1 || n > 3)
				{
					throw new System.ArgumentException("Please ensure to choose from the provided options");
				}
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Press enter to continue");
				Console.ReadLine();
				Console.Clear();
				OpeningUI();
			}

			switch (n)
			{
				case 1:
					Console.Clear();
					GetProfits GetMoney = new GetProfits();
					break;

				case 2:
					Console.Clear();
					EmployeesPay WeeklyPay = new EmployeesPay();
					break;

				case 3:
					Environment.Exit(1);
					break;

				default:
					break;
			}
		}
	}
}
