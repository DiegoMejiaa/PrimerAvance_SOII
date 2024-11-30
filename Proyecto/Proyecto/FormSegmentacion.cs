using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto.Models; // Esto importa la carpeta Models, donde estará la clase Segmento

namespace Proyecto
{
    public partial class FormSegmentacion : Form
    {
        private List<Segmento> memoria;

        public FormSegmentacion()
        {
            InitializeComponent();
            memoria = new List<Segmento>();
        }

        private void btnSimularSegmentacion_Click(object sender, EventArgs e)
        {
            memoria.Clear();
            for (int i = 0; i < 5; i++)
            {
                memoria.Add(new Segmento($"Segmento {i + 1}", 100, true));
            }
            ActualizarListaMemoria();
        }

        private void btnAsignarSegmento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamañoSegmento.Text, out int tamañoSegmento))
            {
                var segmentoDisponible = memoria.Find(s => s.Disponible && s.Tamaño >= tamañoSegmento);
                if (segmentoDisponible != null)
                {
                    segmentoDisponible.Disponible = false;
                    segmentoDisponible.Nombre = $"Ocupado ({tamañoSegmento} KB)";
                    ActualizarListaMemoria();
                }
                else
                {
                    MessageBox.Show("No hay suficiente espacio en la memoria para este segmento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tamaño de segmento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarListaMemoria()
        {
            lstEstadoMemoriaSegmentacion.Items.Clear();
            foreach (var segmento in memoria)
            {
                lstEstadoMemoriaSegmentacion.Items.Add(segmento.ToString());
            }
        }
    }
}
