using Expence_Tracker;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Expence> expenses = new List<Expence>();
        expenses.Add(new Expence("Lunch", 15.50m, "Food"));
        expenses.Add(new Expence("Movie Ticket", 12.00m, "Entertainment"));

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Expense Tracker!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Show Total Spent");
            Console.WriteLine("4. Delete Expense");
            Console.WriteLine("5. Show Expences by Category");
            Console.WriteLine("6. Save To File");
            Console.WriteLine("7. Load From File");
            Console.WriteLine("8. Exit");
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
                    ExpenceManager.AddExpense(expenses, new Expence(name, amount, category));
                    break;
                case "2":
                    ExpenceManager.ShowExpenses(expenses);
                    break;
                case "3":
                    ExpenceManager.ShowTotalSpent(expenses);
                    break;
                case "4":
                    Console.WriteLine("Enter the index of the expense to delete:");
                    int index = int.Parse(Console.ReadLine());
                    ExpenceManager.DeleteExpense(expenses, index);
                    break;
                case "5":
                    Console.WriteLine("Enter the category of expenses to display:");
                    category = Console.ReadLine();
                    ExpenceManager.ShowExpensesByCategory(expenses, category);
                    break;
                case "6":
                    Console.WriteLine("Enter the filename to save expenses to:");
                    string saveFilename = Console.ReadLine();
                    ExpenceManager.SaveExpenses(expenses, saveFilename);
                    Console.WriteLine("File saved!");
                    Console.WriteLine($"Location: {Path.GetFullPath(saveFilename)}");
                    break;
                case "7":
                    Console.WriteLine("Enter the filename to load expenses from:");
                    string loadFilename = Console.ReadLine();
                    ExpenceManager.LoadExpenses(expenses, loadFilename);
                    Console.WriteLine("File loaded!");
                    break;
                case "8":
                    exit = true;
                    break;
            }
        }
    }
}