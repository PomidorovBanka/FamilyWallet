namespace FamilyWallet.core;

public interface IUserRepository
{
    void AddUser(string name);
    void DeleteUser(int id);
}
