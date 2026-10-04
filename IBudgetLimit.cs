namespace KhaiLaba.Core;

public interface IBudgetLimit
{
    int Id { get; get; }
    decimal LimitAmount { get; set; }
    int CategoryId { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
}