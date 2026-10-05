namespace KhaiLaba.Core;

//Категорія транзакції

public interface ICategory
{
    int Id { get; set; }
    string Name { get; set; }
    bool IsExpense { get; set; }
}