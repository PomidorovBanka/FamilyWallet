using FamilyWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWallet.Classes
{
    public class BudgetLimit : IBudgetLimit
    {
        public int Id { get; set; }
        public decimal LimitAmount { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
