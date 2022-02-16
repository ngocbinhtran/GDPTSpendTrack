using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GDPTSpendTrack.Models
{
    public enum TransactionType
    {
        Unknown = 0
        , Donation = 1
        , Expense = 2
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}