using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Domain
{
    /// <summary>
    /// Representa un cliente del banco
    /// </summary>
    class Client
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public Document Document { set; get; }
        public IList<Account> Accounts { set; get; }
    }
}
