namespace KhaiLaba.Core;

//Інформація про транзакцію

public interface ITransaction
{
    int Id { get; get; }
    decimal Amount { get; set; }
    DateTime Date { get; set; }
    int CategoryId { get; set; }
    int UserId { get; set; }
}