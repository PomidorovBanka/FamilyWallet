namespace FamilyWallet.Core;

//Інформація про транзакцію

public interface ITransaction
{
    int Id { get; set; }
    decimal Amount { get; set; }
    DateTime Date { get; set; }
    int CategoryId { get; set; }
    int UserId { get; set; }
}