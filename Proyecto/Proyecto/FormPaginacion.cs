using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto.Models;  // Importar la clase PaginacionModel

namespace Proyecto
{
    public partial class FormPaginacion : Form
    {
        private PaginacionModel<int> paginacion; // Instancia de la clase PaginacionModel
        private const int ITEMS_POR_PAGINA = 5; // Número de elementos por página

        public FormPaginacion()
        {
            InitializeComponent();
            List<int> memoriaPaginacion = new List<int>(); // Lista que contendrá los elementos a paginar

            // Generación de datos dinámicos (por ejemplo, números aleatorios)
            GenerarDatosDinamicos(memoriaPaginacion);

            // Inicializar la clase de paginación con los datos generados dinámicamente
            paginacion = new PaginacionModel<int>(memoriaPaginacion, ITEMS_POR_PAGINA);

            // Mostrar la primera página
            MostrarPagina();
        }

        // Método para generar datos dinámicos
        private void GenerarDatosDinamicos(List<int> memoriaPaginacion)
        {
            Random random = new Random();
            // Generar 50 números aleatorios entre 1 y 1000 (puedes modificar el rango)
            for (int i = 0; i < 50; i++)
            {
                memoriaPaginacion.Add(random.Next(1, 100));
            }
        }

        // Método para mostrar los elementos de la página actual
        private void MostrarPagina()
        {
            lstEstadoMemoriaPaginacion.Items.Clear();

            // Obtener los elementos de la página actual
            var itemsPaginaActual = paginacion.ObtenerItemsDePaginaActual();

            // Agregar los elementos al ListBox
            foreach (var item in itemsPaginaActual)
            {
                lstEstadoMemoriaPaginacion.Items.Add($"Elemento {item}: {item}");
            }

            // Actualizar el texto del label de la página
            lblPaginaActual.Text = $"Página {paginacion.PaginaActual} de {paginacion.TotalPaginas}";

            // Deshabilitar los botones si no hay más páginas
            btnPaginaAnterior.Enabled = paginacion.PaginaActual > 1;
            btnPaginaSiguiente.Enabled = paginacion.PaginaActual < paginacion.TotalPaginas;
        }

        // Evento para cambiar a la página anterior
        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (paginacion.PaginaAnterior())
            {
                MostrarPagina();
            }
        }

        // Evento para cambiar a la página siguiente
        private void btnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            if (paginacion.SiguientePagina())
            {
                MostrarPagina();
            }
        }
    }
}

