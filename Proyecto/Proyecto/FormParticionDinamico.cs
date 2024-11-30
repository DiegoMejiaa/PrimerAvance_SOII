using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormParticionDinamica : Form
    {
        private List<int> memoriaDinamica; // Lista para simular la memoria dinámica
        private List<int> procesosDinamicos; // Lista para almacenar los tamaños de los procesos asignados

        public FormParticionDinamica()
        {
            InitializeComponent();
            memoriaDinamica = new List<int> { 0, 0, 0, 0, 0 }; // Inicializar 5 bloques de memoria libres
            procesosDinamicos = new List<int>(); // Inicializa la lista de procesos
        }

        private void btnSimularDinamico_Click(object sender, EventArgs e)
        {
            lstEstadoMemoriaDinamica.Items.Clear();

            // Mostrar el estado actual de la memoria
            for (int i = 0; i < memoriaDinamica.Count; i++)
            {
                lstEstadoMemoriaDinamica.Items.Add($"Bloque {i + 1}: {(memoriaDinamica[i] == 0 ? "Libre" : $"Ocupado por Proceso de tamaño {memoriaDinamica[i]}")}");
            }
        }

        private void btnAsignarProcesoDinamico_Click(object sender, EventArgs e)
        {
            int tamañoProceso;
            if (int.TryParse(txtTamañoProcesoDinamico.Text, out tamañoProceso))
            {
                bool asignado = false;

                // Buscar un bloque libre que sea lo suficientemente grande para el proceso
                for (int i = 0; i < memoriaDinamica.Count; i++)
                {
                    if (memoriaDinamica[i] == 0 && tamañoProceso <= (i + 1) * 1000) // Si hay espacio suficiente en un bloque libre
                    {
                        memoriaDinamica[i] = tamañoProceso;
                        procesosDinamicos.Add(tamañoProceso);
                        asignado = true;
                        break;
                    }
                }

                if (asignado)
                {
                    MessageBox.Show("Proceso asignado con éxito.");
                }
                else
                {
                    MessageBox.Show("No hay bloques suficientes para este proceso.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un tamaño válido para el proceso.");
            }

            // Actualizar el estado de la memoria después de la asignación
            btnSimularDinamico_Click(sender, e); // Llamar al simulador para actualizar el estado
        }
    }
}