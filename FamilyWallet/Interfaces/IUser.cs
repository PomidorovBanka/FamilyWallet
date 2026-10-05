namespace KhaiLaba.Core;

//Клас із інформацією про користувача

public interface IUser
{
    int Id { get; set; }
    string Name { get; set; }
    string Email { get; set; }
}