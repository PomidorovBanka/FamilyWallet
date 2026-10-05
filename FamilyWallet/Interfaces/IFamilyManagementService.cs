namespace KhaiLaba.Core;

//Управління додаванням та видаленням членів сім'ї

public interface IFamilyManagementService
{
    void AddFamilyMember(int familyId, int userId);
    void RemoveFamilyMember(int familyId, int userId);
    IEnumerable<IUser> GetFamilyMembers(int familyId);
}