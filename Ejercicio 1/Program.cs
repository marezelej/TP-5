using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AgendaDbContext db = new AgendaDbContext())
            {
                Persona persona = new Persona
                {
                    PersonaId = 1,
                    Nombre = "Martín",
                    Apellido = "Lejman",
                    Telefonos = new List<Telefono>
                    {
                        new Telefono
                        {
                            TelefonoId = 1,
                            Numero = "3447412408",
                            Tipo = "Celular"
                        }
                    }
                };

                db.Personas.Add(persona);

                db.SaveChanges();

                foreach ( var item in db.Personas )
                {
                    Console.WriteLine("Persona encontrada Nombre:{0}, Apellido:{1}, IdPersona:{2}",
                        item.Nombre,
                        item.Apellido,
                        item.PersonaId);
                }
                Console.ReadKey();
            }
        }
    }
}
