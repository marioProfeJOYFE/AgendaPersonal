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
    public partial class Citas : Page
    {
        ObservableCollection<Cita> ListaCitas;
        public Citas()
        {
            InitializeComponent();
            //Crear una lista para almacenar las citas vacía
            //List<Cita> ListaCitas = new List<Cita>();
            //Crear una lista con valores por defecto
            ListaCitas =  new ObservableCollection<Cita>
            {
                new Cita(titulo: "Comida", fecha: DateTime.Now, descripcion: "Comida en el restaurante"),
                new Cita(titulo: "Reunion", fecha: DateTime.Now.AddDays(1), descripcion: "Reunion con Tere"),
            };
            //Asignar la lista al ListBox(llamado ListaCitasInterfaz en el XAML)
            ListaCitasInterfaz.ItemsSource = ListaCitas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaCitas.Add(new Cita(titulo: TxtTituloCita.Text, fecha: DatePickerCita.SelectedDate ?? DateTime.Now, descripcion: TxtDescripcionCita.Text));
            TxtTituloCita.Clear();
            TxtDescripcionCita.Clear();
            DatePickerCita.SelectedDate = null;
        }

    }
}
