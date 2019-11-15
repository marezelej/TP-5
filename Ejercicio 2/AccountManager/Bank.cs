using System;

namespace AccountManager
{
    public class Bank
    {
        public Bank() { }
           
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            List<AccountMovmentDTO> mAccountMovements = new List<AccountMovmentDTO>();

        }
        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAcountID)
        {

        }


    }
}
