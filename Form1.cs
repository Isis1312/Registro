using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resgistra
{
    public partial class Form1 : Form
    {
        public Cursos cursos;
        public Form1()
        {
            InitializeComponent();
            cursos = new Cursos();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string codigo = txcodigo.Text;
            string datos = txdatos.Text;
            string nombre = txnombrecurso.Text;
            DateTime fechain = this.fechain.Value;
            DateTime fechafin = this.fechafin.Value;
            Boolean activo = this.si.Checked;
            int horas = ((int)this.nunhoras.Value);
            int estuinates = ((int)this.nunestudiantes.Value);
            string modalidad = this.cbmodalidad.Text;

            Informacion informacion = new Informacion(codigo, datos, nombre, fechain, fechafin, activo, modalidad, estuinates, horas);
            cursos.Guardar(informacion);

           

        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.txcodigo.Clear();
            this.txdatos.Clear();
            this.txnombrecurso.Clear();
        }
    }
}
