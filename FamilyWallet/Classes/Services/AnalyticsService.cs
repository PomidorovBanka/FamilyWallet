using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        public decimal GetTotalExpenses(int userId, DateTime startDate, DateTime endDate)
        {
            // Загальні витрати користувача за період
            throw new NotImplementedException();
        }

        public decimal GetTotalIncome(int userId, DateTime startDate, DateTime endDate)
        {
            // Загальний дохід користувача за період
            throw new NotImplementedException();
        }

        public IDictionary<string, decimal> GetExpensesByCategory(int userId)
        {
            // Групування витрат за категоріями
            throw new NotImplementedException();
        }
    }
}
