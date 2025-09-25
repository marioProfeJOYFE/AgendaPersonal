using System;
using System.Collections.Generic;
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
        public Contactos()
        {
            InitializeComponent();
            //Crear una lista para almacenar las citas vacía
            //List<Cita> ListaCitas = new List<Cita>();
            //Crear una lista con valores por defecto
            List<Contacto> ListaContactos = new List<Contacto>
            {
                new Contacto{Nombre="Ana", Apellido1="Lopez", Apellido2="Martinez", FechaCreacion=DateTime.Now, genero="Femenino" },
                new Contacto{Nombre="Luis", Apellido1="Garcia", Apellido2="Hernandez", FechaCreacion=DateTime.Now.AddDays(1), genero="Masculino" },
            };
            //Asignar la lista al ListBox(llamado ListaCitasInterfaz en el XAML)
            ListaContactosInterfaz.ItemsSource = ListaContactos;
        }
    }
}
