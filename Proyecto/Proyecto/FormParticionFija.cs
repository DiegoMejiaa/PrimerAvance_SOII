using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormParticionFija : Form
    {
        private List<Particion> particiones;
        private List<Proceso> procesos;

        public FormParticionFija()
        {
            InitializeComponent();
            particiones = new List<Particion>();
            procesos = new List<Proceso>();
        }

        // Simulación de particionamiento fijo
        private void btnSimularParticionFija_Click_1(object sender, EventArgs e)
        {
            particiones.Clear();
            particiones.Add(new Particion(100)); // 100 KB
            particiones.Add(new Particion(200)); // 200 KB
            particiones.Add(new Particion(300)); // 300 KB

            lstEstadoMemoria.Items.Clear();
            foreach (var particion in particiones)
            {
                lstEstadoMemoria.Items.Add($"Partición {particion.Tamaño} KB - {particion.Estado} - Espacio Restante: {particion.EspacioRestante} KB");
            }
        }

        // Asignar proceso
        private void btnAsignarProceso_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamañoProceso.Text, out int tamañoProceso))
            {
                Proceso proceso = new Proceso(tamañoProceso);
                procesos.Add(proceso);

                bool asignado = AsignarProcesoAParticion(proceso);
                if (asignado)
                {
                    MessageBox.Show($"Proceso de {tamañoProceso} KB asignado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"No se pudo asignar el proceso de {tamañoProceso} KB. No hay particiones disponibles.");
                }

                // Actualizar la vista
                lstEstadoMemoria.Items.Clear();
                foreach (var particion in particiones)
                {
                    lstEstadoMemoria.Items.Add($"Partición {particion.Tamaño} KB - {particion.Estado} - Espacio Restante: {particion.EspacioRestante} KB");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tamaño válido para el proceso.");
            }
        }

        // Asignar un proceso a una partición
        private bool AsignarProcesoAParticion(Proceso proceso)
        {
            foreach (var particion in particiones)
            {
                if (particion.Estado == "Disponible" && particion.AsignarProceso(proceso))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
