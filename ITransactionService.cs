namespace KhaiLaba.Core;

// СервисТранзакций

public interface ITransactionService
{
    void CreateTransaction(ITransaction transaction);
    void DeleteTransaction(int transactionId);
    IEnumerable<ITransaction> GetUserTransactions(int userId);
}