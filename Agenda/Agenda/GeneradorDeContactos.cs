using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class GeneradorDeContactos
    {
        private static List<string> ListaNombres = new List<string>
        {
            "Alexandro", "Emanuel","Wilson","Cristina","Pedro"
        };

        private static List<string> ListaApellidos = new List<string>
        {
            "Múnera", "González","Tobón","Sifuentes","Mira"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 25; i++)
            {
                var nombre = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var apellidos = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var calle = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var contacto = new Contacto
                {
                    Nombre = nombre + " " + apellidos,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida " + calle + ", Número " + random.Next(1, 1000)
                };

                contactos.Add(contacto);
            }

            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(")");
            telefono.Append(random.Next(1000000, 9999999));
            return telefono.ToString();
        }
    }
}
