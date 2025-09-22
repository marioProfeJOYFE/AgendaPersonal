using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonal
{
    public class Cita
    {
        public string Titulo { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public Cita(string titulo, DateTime fecha, string descripcion)
        {
            Titulo = titulo;
            Fecha = fecha;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Fecha: {Fecha.ToShortDateString()}, Descripcion: {Descripcion}";
        }
    }
}
