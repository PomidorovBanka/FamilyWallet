namespace KhaiLaba.Core;

//ФинансоваяЦель

public interface IFinancialGoal
{
    int Id { get; get; }
    string Title { get; set; }
    decimal TargetAmount { get; set; }
    decimal CurrentAmount { get; set; }
    DateTime Deadline { get; set; }
}