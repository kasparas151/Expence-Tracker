using Expence_Tracker;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Expense Tracker!");
            List<Expence> expenses = new List<Expence>();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Show Total Spent");
            Console.WriteLine("4. Delete Expense");
            Console.WriteLine("5. Show Expences by Category");
            Console.WriteLine("6. Save To File");
            Console.WriteLine("7. Load From File");
            Console.WriteLine("8. Exit");
            expenses.Add(new Expence("Lunch", 15.50m, "Food"));
            expenses.Add(new Expence("Movie Ticket", 12.00m, "Entertainment"));

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter expense name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter expense amount:");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter expense category:");
                    string category = Console.ReadLine();
                    expenses.Add(new Expence(name, amount, category));
                    break;
                case "2":
                    foreach (var expense in expenses)
                    {
                        Console.WriteLine(expense);
                    }
                    break;
                case "3":
                    Console.WriteLine($"Total Spent: {expenses.Sum(e => e.Amount):C}");
                    break;
                case "8":
                    exit = true;
                    break;
            }
        }
    }
}