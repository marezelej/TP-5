using System;

namespace AccountManager.Domain
{
    /// <summary>
    /// Representa un movimento en una cuenta bancaria
    /// </summary>
    public class AccountMovement
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }
    }
}