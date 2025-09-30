using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaPersonal
{
    /// <summary>
    /// Lógica de interacción para Contactos.xaml
    /// </summary>
    public partial class Contactos : Page
    {
        ObservableCollection<Contacto> ListaContactos;
        public Contactos()
        {
            InitializeComponent();
            //Crear una lista para almacenar las citas vacía
            //List<Cita> ListaCitas = new List<Cita>();
            //Crear una lista con valores por defecto
            ListaContactos = new ObservableCollection<Contacto>
            {
                new Contacto{Nombre="Ana", Apellido1="Lopez", Apellido2="Martinez", FechaCreacion=DateTime.Now, Genero="Femenino" },
                new Contacto{Nombre="Luis", Apellido1="Garcia", Apellido2="Hernandez", FechaCreacion=DateTime.Now.AddDays(1), Genero="Masculino" },
            };
            //Asignar la lista al ListBox(llamado ListaCitasInterfaz en el XAML)
            ListaContactosInterfaz.ItemsSource = ListaContactos;
            ComboGenero.ItemsSource = new List<string> { "Femenino", "Masculino", "Otro" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaContactos.Add(new Contacto
            {
                Nombre = TxtNombreContacto.Text,
                Apellido1 = TxtApellido1Contacto.Text,
                Apellido2 = TxtApellido2Contacto.Text,
                FechaCreacion = DateTime.Now,
                Genero = ComboGenero.SelectedItem as string ?? "Otro"
            });
        }

        private void ListaContactosInterfaz_CambioUsuarioSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            Contacto contactoSeleccionado = (Contacto) ListaContactosInterfaz.SelectedItem;
            if(contactoSeleccionado != null)
            {
                DetalleNombre.Text = "Nombre: " + contactoSeleccionado.Nombre;
                DetalleApellidos.Text = "Apellidos: " + contactoSeleccionado.Apellido1 + " " + contactoSeleccionado.Apellido2;
                DetalleGenero.Text = "Genero: " + contactoSeleccionado.Genero;
                DetalleFecha.Text = "Creado el " + contactoSeleccionado.FechaCreacion.ToString("U");
            }
        }
    }
}
