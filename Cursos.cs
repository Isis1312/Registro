using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistra
{
    public class Cursos
    {
        private List<Informacion> list;
        public List<Informacion> List { get { return list; } set { list = value; } }

        public Cursos()
        {
            List = new List<Informacion>();
        }

        public void Guardar(Informacion b)
        {
            List.Add(b);
        }

        public Boolean Recorrer(string n)
        {
            Boolean x = false;
            Int16 w = 0;
            while ((w < List.Count) && (!x))
            {
                if (List[w].Codigo == n) x = true;
                w++;
            }
            return x;
        }
        public Boolean Buscar(String n)
        {
            Boolean x = false;
            Int16 w = 0;
            while ((w < List.Count) && (!x))
            {
                if (List[w].Nombre == n) x = true;
                w++;
            }
            return x;
        }

        public void Modificar(Informacion x)
        {
            Int16 w = 0;
            while (w < List.Count)
            {
                if (List[w].Codigo == x.Codigo)
                {
                    List[w].FechaIn = x.FechaIn;
                    List[w].FechaFin = x.FechaFin;
                    List[w].Nombre = x.Nombre;
                    List[w].Horas = x.Horas;
                    List[w].Estudiantes = x.Estudiantes;
                    List[w].Datos = x.Datos;
                    List[w].Activo = x.Activo;
                    List[w].Modalidad = x.Modalidad;

                    break;
                }
                else w++;
            }
        }
        public void Eliminar(Informacion x)
        {
            Int16 w = 0;
            while (w < List.Count)
            {
                if (List[w].Codigo == x.Codigo)
                {
                    List[w].Activo = false;
                    break;
                }
                else w++;
            }
        }
    }
}
