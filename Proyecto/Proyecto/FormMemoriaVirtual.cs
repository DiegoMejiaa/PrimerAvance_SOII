using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormMemoriaVirtual : Form
    {
        private const int TAM_MEMORIA_FISICA = 10; // Número de marcos de memoria física
        private const int TAM_MEMORIA_VIRTUAL = 20; // Número de páginas virtuales
        private List<int> memoriaFisica; // Memoria física
        private List<int> memoriaVirtual; // Memoria virtual
        private Queue<int> colaMemoriaVirtual; // Cola para manejar la memoria virtual

        public FormMemoriaVirtual()
        {
            InitializeComponent();
            memoriaFisica = new List<int>(new int[TAM_MEMORIA_FISICA]); // Inicializa memoria física
            memoriaVirtual = new List<int>(new int[TAM_MEMORIA_VIRTUAL]); // Inicializa memoria virtual
            colaMemoriaVirtual = new Queue<int>();

            // Simula la memoria virtual llena con números de página
            for (int i = 0; i < TAM_MEMORIA_VIRTUAL; i++)
            {
                memoriaVirtual[i] = i + 1; // Páginas 1 a 20
                colaMemoriaVirtual.Enqueue(i + 1);
            }
        }

        // Simula el fallo de página
        private void btnSimularFalloPagina_Click(object sender, EventArgs e)
        {
            int pagina;
            if (int.TryParse(txtPagina.Text, out pagina) && pagina > 0 && pagina <= TAM_MEMORIA_VIRTUAL)
            {
                // Verificar si la página ya está en la memoria física
                if (!memoriaFisica.Contains(pagina))
                {
                    SimularFalloPagina(pagina);
                }
                else
                {
                    MessageBox.Show("La página ya está en memoria.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de página válido.");
            }
        }

        // Simula el manejo del fallo de página
        private void SimularFalloPagina(int pagina)
        {
            // Si hay espacio en la memoria física
            for (int i = 0; i < TAM_MEMORIA_FISICA; i++)
            {
                if (memoriaFisica[i] == 0)
                {
                    memoriaFisica[i] = pagina; // Asigna la página en memoria física
                    MostrarEstadoMemoria();
                    MessageBox.Show($"Página {pagina} cargada en memoria.");
                    return;
                }
            }

            // Si no hay espacio, realiza el reemplazo (usamos FIFO para el reemplazo)
            int paginaReemplazada = memoriaFisica[0]; // El primer elemento es el que se reemplaza
            memoriaFisica[0] = pagina; // Reemplaza la página
            MostrarEstadoMemoria();
            MessageBox.Show($"Página {paginaReemplazada} reemplazada por la página {pagina}.");
        }

        // Muestra el estado de la memoria (física y virtual)
        private void MostrarEstadoMemoria()
        {
            lstMemoriaFisica.Items.Clear();
            lstMemoriaVirtual.Items.Clear();

            // Mostrar la memoria física
            foreach (var item in memoriaFisica)
            {
                lstMemoriaFisica.Items.Add(item == 0 ? "Libre" : $"Página {item}");
            }

            // Mostrar la memoria virtual
            foreach (var item in memoriaVirtual)
            {
                lstMemoriaVirtual.Items.Add($"Página {item}");
            }
        }
    }
}
