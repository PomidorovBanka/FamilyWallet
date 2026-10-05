using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsExpense { get; set; }
    }
}
