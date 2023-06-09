﻿using Expenses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Repositories
{
    public class ExpensesRepository : IExpensesRepository
    {
        public readonly ApplicationdbContext _context;

        public ExpensesRepository(ApplicationdbContext context)
        {
            _context = context;
        }

        public void Add(ExpenseModel expense)
        {
            try
            {
                _context.ExpensesTable.Add(expense);
                _context.SaveChanges();
            }catch (Exception) {
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseModel> GetAllExpenses()
        {
            try
            {
                var expenses = _context.ExpensesTable.ToList();
                return expenses;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public ExpenseModel GetExpenseById(int id)
        {
            try
            {
                var expense = _context.ExpensesTable.Find(id);
                return expense;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public IEnumerable<ExpenseModel> Search(string searchString)
        {
            try
            {
                var searchExpenses = GetAllExpenses().Where(x => x.Title.Contains(searchString)).ToList();
                return searchExpenses;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public int Update(ExpenseModel expense)
        {
            try
            {
                _context.Entry(expense).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
