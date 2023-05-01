using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Model
{
     public class ExpenseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal MoneySpent { get; set; }

        public DateTime ExpenseDate { get; set; }

        public string Category { get; set; }
    }
}
