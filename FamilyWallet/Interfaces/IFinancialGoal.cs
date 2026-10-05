namespace FamilyWallet.Core;

//Финансова ціль

public interface IFinancialGoal
{
    int Id { get; set; }
    string Title { get; set; }
    decimal TargetAmount { get; set; }
    decimal CurrentAmount { get; set; }
    DateTime Deadline { get; set; }
}