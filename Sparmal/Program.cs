using System;
namespace Sparmal
{
    class Program
    {
        static void Main(string[] args) // startpunkt
        {

            //Ansiconsole.Markup(ConsoleColor"black")
            Console.WriteLine("what are you saving for");
            string name = Console.ReadLine();


            decimal total = ReadAmount("How much do you need in total (kr)? ");
            decimal savings = ReadAmount("How much do you want to save per month (kr)? ");


            //Console.WriteLine($"You will reach Wedding in 17 months!");
            decimal months = Math.Ceiling(total / savings);
            Console.WriteLine($"You will reach {name} in {months} months!");



            //decimal result = Math.Ceiling(10.2m);
            //Console.WriteLine(result);   // prints 11

            Console.ReadKey();
        }
   

        // method below main, but still inside class Program
        static decimal ReadAmount(string question)
        {
            decimal amount;
            Console.Write(question);

            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("please enter a number greater than 0: ");
            }
            return amount;


            //SavingsGoal goal = new SavingsGoal();

            //Console.Write("what are you saving for? ");
            //goal.name = Console.ReadLine();

            //goal.Target = ReadAmount("How much do you need in total (kr)? ");
            //goal.Monthly = ReadAmount("How much do you want to save per month (kr)? ");
            //Console.WriteLine($"you will reach {goal.Name} in {goal.MonthsLeft()} months ({goal.ReachedDate():yyyy-MM-dd})!");

        }

    }
}