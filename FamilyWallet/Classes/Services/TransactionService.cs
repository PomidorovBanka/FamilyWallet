using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes.Services
{
    public class TransactionService : ITransactionService
    {
        public void CreateTransaction(ITransaction transaction)
        {
            // Створення нової транзакції
            throw new NotImplementedException();
        }

        public void DeleteTransaction(int transactionId)
        {
            // Видалення транзакції
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetUserTransactions(int userId)
        {
            // Отримання списку транзакцій конкретного користувача
            throw new NotImplementedException();
        }
    }
}
