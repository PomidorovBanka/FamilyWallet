namespace KhaiLaba.Core;

//Сервіс аутентифікації та авторизації користувачів

public interface IAuthService
{
    bool Register(string name, string email, string password);
    string Login(string email, string password);
    void Logout(int userId);
}