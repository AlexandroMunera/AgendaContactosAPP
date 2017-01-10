using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda
{
    public class PaginaListaContactos : MasterDetailPage
    {
        public PaginaListaContactos()
        {
            var lista = new ListView();
            lista.ItemsSource = GeneradorDeContactos.CrearContactos().OrderBy(p => p.Nombre);

            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };

            Detail = new PaginaContacto(GeneradorDeContactos.CrearContactos().First());

            
        }
    }
}
