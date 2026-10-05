using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes.Services
{
    public class FamilyManagementService : IFamilyManagementService
    {
        public void AddFamilyMember(int familyId, int userId)
        {
            // Додавання користувача до сімейного бюджету
            throw new NotImplementedException();
        }

        public void RemoveFamilyMember(int familyId, int userId)
        {
            // Видалення користувача з сімейного бюджету
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetFamilyMembers(int familyId)
        {
            // Отримання списку членів сім'ї
            throw new NotImplementedException();
        }
    }
}
