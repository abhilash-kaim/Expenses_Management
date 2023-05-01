using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Model;

namespace Expenses.DataAccess
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options): base (options)
        { }

        public DbSet<ExpenseModel> ExpensesTable { get; set; }
    }
}
