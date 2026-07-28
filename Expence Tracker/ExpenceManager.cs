using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Expence_Tracker
{
    internal class ExpenceManager
    {
        public static void AddExpense(List<Expence> expenses, Expence expense)
        {
            expenses.Add(expense);
        }

        public static void ShowExpenses(List<Expence> expenses)
        {
            foreach (var expense in expenses)
            {
                Console.WriteLine(expense);
            }
        }

        public static void ShowTotalSpent(List<Expence> expenses)
        {
            Console.WriteLine($"Total Spent: {expenses.Sum(e => e.Amount):C}");
        }

        public static void DeleteExpense(List<Expence> expenses, int index)
        {
            if (index >= 0 && index < expenses.Count)
            {
                expenses.RemoveAt(index);
                Console.WriteLine("Expense deleted.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public static void ShowExpensesByCategory(List<Expence> expenses, string category)
        {
            var categoryExpenses = expenses.Where(e => e.Category == category);
            foreach (var expense in categoryExpenses)
            {
                Console.WriteLine(expense);
            }
        }
        public static void SaveExpenses(List<Expence> expenses, string filename)
        {
            string json = JsonSerializer.Serialize(expenses);
            File.WriteAllText(filename, json);
        }
             
        public static void LoadExpenses(List<Expence> expenses, string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }
            string json = File.ReadAllText(filename);
            var loadedExpenses = JsonSerializer.Deserialize<List<Expence>>(json);

            if (loadedExpenses != null)
            {
                expenses.Clear();
                expenses.AddRange(loadedExpenses);
            }
        }

    }
}
