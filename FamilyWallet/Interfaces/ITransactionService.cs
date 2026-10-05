namespace KhaiLaba.Core;

// Клас із інформацією про транзакцію


public interface ITransactionService
{
    void CreateTransaction(ITransaction transaction);
    void DeleteTransaction(int transactionId);
    IEnumerable<ITransaction> GetUserTransactions(int userId);
}