using System;

namespace AccountManager.IO
{
    class AccountMovementDTO
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }

    }
}
