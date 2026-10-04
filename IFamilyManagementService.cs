namespace KhaiLaba.Core;

public interface IFamilyManagementService
{
    void AddFamilyMember(int familyId, int userId);
    void RemoveFamilyMember(int familyId, int userId);
    IEnumerable<IUser> GetFamilyMembers(int familyId);
}