using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Expence_Tracker
{
    public class Expence
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        public Expence(string description, decimal amount, string category)
        {
            Description = description;
            Amount = amount;
            Category = category;
            Date = DateTime.Now;
        }



        public override string ToString() {
            return $"[{Date:yyyy-MM-dd}] {Description} - {Amount:C} ({Category})";
        }
    }
}
