using System;

namespace TestApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			System.Console.Write("First Name : ");
			string firstName = System.Console.ReadLine();

			System.Console.Write("Middle Initial : ");
			string middleInitial = System.Console.ReadLine();

			System.Console.Write("Last Name : ");
			string lastName = System.Console.ReadLine();

			string fullName = firstName + " " + middleInitial + ". " + lastName;
			System.Console.WriteLine("Your Full Name is : " + fullName);

			System.Console.Write("Height in Feet : ");

			int heightFeet = int.Parse(System.Console.ReadLine());
			System.Console.Write("Extra Inches : ");

			double extraInches = double.Parse(System.Console.ReadLine());
			double heightInches = heightFeet * 12;
			double totalInches = heightInches + extraInches;

			double heightInCM = double.Parse(System.Console.ReadLine());

			System.Console.Write("How old are you? : ");
			int age = 19;
			age = int.Parse(System.Console.ReadLine());

			System.Console.Write("Are you a legal US Citizen? : ");
			bool isCitzen = true;
			isCitzen = true;
			bool canVote = true;
			canVote = true; 
		}
	}
}
