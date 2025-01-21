using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistra
{
    public class Informacion
    {
        //Variables y instaciacion
        private string codigo;
        private string datos;
        private string nombre;
        private DateTime fechaIn;
        private DateTime fechaFin;
        private Boolean activo;
        private String modalidad;
        private int horas;
        private int estudiantes;

        public string Codigo { get { return codigo; } set{ codigo = value; } }
        public string Datos { get { return datos; } set { datos = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime FechaIn { get { return fechaIn; } set { fechaIn = value; } }
        public DateTime FechaFin { get { return fechaFin; } set { fechaFin = value; } } 
        public Boolean Activo { get { return activo; } set { activo = value; } }
        public String Modalidad { get { return modalidad; } set { modalidad = value; } }
        public int Estudiantes { get { return estudiantes; } set { estudiantes = value; } }
        public int Horas { get { return horas; } set {  horas = value; } }

        public Informacion(string codigo, string datos, string nombre, DateTime fechain, DateTime fechafin, Boolean activo, string modalidad, int estudiantes, int horas)
        {
            Codigo = codigo;
            Datos = datos;
            Nombre = nombre;
            FechaIn = fechaIn;
            FechaFin = fechaFin;
            Activo = activo;
            Modalidad = modalidad;
            Estudiantes = estudiantes;
            Horas = horas;
        }

        public Informacion(string codigo)
        {
            Codigo = codigo;
          
        }
    }
}
