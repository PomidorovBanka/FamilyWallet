using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes.Services
{
    public class AuthService : IAuthService
    {
        public bool Register(string name, string email, string password)
        {
            // Реєстрація нового користувача
            throw new NotImplementedException();
        }

        public string Login(string email, string password)
        {
            // Аутентифікація та повернення токена/ідентифікатора
            throw new NotImplementedException();
        }

        public void Logout(int userId)
        {
            // Логіка виходу з системи
            throw new NotImplementedException();
        }
    }
}
