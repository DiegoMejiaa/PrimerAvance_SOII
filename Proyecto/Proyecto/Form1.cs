using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParticionFijo_Click(object sender, EventArgs e)
        {
            FormParticionFija formFija = new FormParticionFija();
            formFija.Show();  // Abre el formulario de Particionamiento Fijo
        }

        private void btnParticionDinamico_Click(object sender, EventArgs e)
        {
            FormParticionDinamica form = new FormParticionDinamica();

            // Mostrar el formulario
            form.Show();
        }

        private void btnPaginacion_Click(object sender, EventArgs e)
        {
            FormPaginacion formPaginacion = new FormPaginacion();
            formPaginacion.Show();  // Abre el formulario de Paginación
        }

        private void btnSegmentacion_Click(object sender, EventArgs e)
        {
            FormSegmentacion formSegmentacion = new FormSegmentacion();
            formSegmentacion.Show();  // Abre el formulario de Segmentación
        }

        private void btnMemoriaVirtual_Click(object sender, EventArgs e)
        {
            FormMemoriaVirtual formMemoriaVirtual = new FormMemoriaVirtual();
            formMemoriaVirtual.Show();  // Abre el formulario de Memoria Virtual
        }
    }
}
