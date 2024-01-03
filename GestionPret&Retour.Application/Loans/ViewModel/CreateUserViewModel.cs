using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.ViewModel
{
    public class CreateUserViewModel
    {
        public int Id;
        private Boolean IsBanned;
        private int CountPenalties;

        public CreateUserViewModel(int userId, Boolean v1, int v2)
        {
            this.Id = userId;
            this.IsBanned = v1;
            this.CountPenalties = v2;
        }

       
    }
}
