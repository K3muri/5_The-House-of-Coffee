using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_House_of_Coffee
{
	class EmployeesPay
	{
		public EmployeesPay()
		{
			Recursion();
			Console.ReadLine();
			Console.Clear();
			UI gobacktoUI = new UI();
		}	
	
		public void Recursion()
		{
			try
			{
				Console.WriteLine("Enter total number of employees:");
				int employees = int.Parse(Console.ReadLine());
				Console.WriteLine();
				NumberOfEmpLoop(employees);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.Write("Press enter to continue");
				Console.ReadLine();
				Console.Clear();
				Recursion();
			}
		}

		int i;
		double WeeklyPay = 0;

		public void NumberOfEmpLoop(int numberOfEmps)
		{
			for (i = 1; i < numberOfEmps + 1; i++)
			{
				WeeklyPayrollCalc(i);
			}

			Console.WriteLine($"The total pay for all employees is: ${WeeklyPay}");
		}

		double RegHourlyPay = 12.5;

		public double WeeklyPayrollCalc(int employeeNumber)
		{
			Console.WriteLine($"Please enter total number of hours for employee {employeeNumber}");

			double totalHours = double.Parse(Console.ReadLine());
			double doubleTimeRate = (RegHourlyPay * 1.5);
			double totalWeeklyPay;

			if (totalHours > 40)
			{
			    double doubleTimeHours = (totalHours - 40);
				double doubleTimePay   = doubleTimeHours * doubleTimeRate;
				double regTimePay      = 40 * RegHourlyPay;

				totalWeeklyPay = doubleTimePay + regTimePay;
			}

			else
			{
				double regTimePay = totalHours * RegHourlyPay;
				totalWeeklyPay = regTimePay;
			}

			Console.WriteLine($"Total weekly pay for employee {employeeNumber} is ${totalWeeklyPay}\n");
			WeeklyPay += totalWeeklyPay;
			return totalWeeklyPay;
		}
	}
}