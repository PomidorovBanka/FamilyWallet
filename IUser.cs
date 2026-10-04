namespace KhaiLaba.Core;

public interface IUser
{
    int Id { get; get; }
    string Name { get; set; }
    string Email { get; set; }
}