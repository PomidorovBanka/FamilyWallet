namespace KhaiLaba.Core;

//Клас із інформацією про користувача

public interface IUser
{
    int Id { get; get; }
    string Name { get; set; }
    string Email { get; set; }
}