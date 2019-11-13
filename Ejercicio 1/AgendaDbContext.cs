using System.Data.Entity;

namespace Ejercicio_1
{
    internal class AgendaDbContext : DbContext
    {
        public AgendaDbContext() : base("AgendaConnection")
        {

        }

        public IDbSet<Persona> Personas { get; set; }
        public IDbSet<Telefono> Telefonos { get; set; }
    }
}