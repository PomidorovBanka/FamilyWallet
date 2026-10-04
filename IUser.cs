namespace KhaiLaba.Core;

//Пользователь

public interface IUser
{
    int Id { get; get; }
    string Name { get; set; }
    string Email { get; set; }
}