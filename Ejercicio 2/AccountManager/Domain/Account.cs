using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Domain
{
    /// <summary>
    /// Representa la cuenta bancaria de un cliente
    /// </summary>
    public class Account
    {
        public int Id { set; get; }
        public Client Client { set; get; }
        public string Name { set; get; }
        public double OverdraftLimit { set; get; }
        public IList<AccountMovement> Movements { set; get; }
        
        /// <summary>
        /// Calcula el balance de la cuenta, evaluando los distintos movimientos realizados
        /// </summary>
        /// <returns>El balance de la cuenta</returns>
        public double GetBalance()
        {
            return 0;
        }
        /// <summary>
        /// Devuelve los últimos pCount movimientos en la cuenta
        /// </summary>
        /// <param name="pCount">La cantidad de movimientos a devolver</param>
        /// <returns>Un iterador a travez de los ultimos movimientos encontrados</returns>
        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return Movements.Skip(Math.Max(0, Movements.Count - pCount));
        }
    }
}
