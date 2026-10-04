namespace KhaiLaba.Core;

//Сервіс аналітики для отримання статистики та звітів про транзакції користувача

public interface IAnalyticsService
{
    decimal GetTotalExpenses(int userId, DateTime startDate, DateTime endDate);
    decimal GetTotalIncome(int userId, DateTime startDate, DateTime endDate);
    IDictionary<string, decimal> GetExpensesByCategory(int userId);
}