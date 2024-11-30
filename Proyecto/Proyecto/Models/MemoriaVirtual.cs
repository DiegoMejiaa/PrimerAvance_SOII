using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Models
{
    public class MemoriaVirtual
    {
        public List<Pagina> MemoriaFisica { get; set; }  // Memoria física
        public Queue<Pagina> MemoriaVirtua { get; set; }  // Memoria virtual (virtual memory)

        public MemoriaVirtual(int tamMemoriaFisica, int tamMemoriaVirtual)
        {
            MemoriaFisica = new List<Pagina>(new Pagina[tamMemoriaFisica]);
            MemoriaVirtua = new Queue<Pagina>();

            // Inicializar memoria virtual con páginas
            for (int i = 1; i <= tamMemoriaVirtual; i++)
            {
                MemoriaVirtua.Enqueue(new Pagina(i));
            }
        }

        // Mostrar estado de la memoria
        public void MostrarEstadoMemoria(ListBox lstMemoriaFisica, ListBox lstMemoriaVirtual)
        {
            lstMemoriaFisica.Items.Clear();
            lstMemoriaVirtual.Items.Clear();

            // Mostrar memoria física
            foreach (var pagina in MemoriaFisica)
            {
                lstMemoriaFisica.Items.Add(pagina == null ? "Libre" : $"Página {pagina.Numero}");
            }

            // Mostrar memoria virtual
            foreach (var pagina in MemoriaVirtua)
            {
                lstMemoriaVirtual.Items.Add($"Página {pagina.Numero}");
            }
        }

        // Simula un fallo de página y reemplazo de página usando FIFO
        public void SimularFalloDePagina(int pagina)
        {
            // Comprobar si la página está ya en la memoria física
            if (MemoriaFisica.All(p => p == null || p.Numero != pagina))
            {
                // Reemplazo si no hay espacio
                ReemplazarPagina(pagina);
            }
            else
            {
                MessageBox.Show("La página ya está en memoria.");
            }
        }

        private void ReemplazarPagina(int nuevaPagina)
        {
            // Comprobar si hay espacio en la memoria física
            if (MemoriaFisica.Contains(null))
            {
                // Cargar página en memoria física si hay espacio
                for (int i = 0; i < MemoriaFisica.Count; i++)
                {
                    if (MemoriaFisica[i] == null)
                    {
                        MemoriaFisica[i] = new Pagina(nuevaPagina);
                        break;
                    }
                }
            }
            else
            {
                // Si no hay espacio, reemplazar usando FIFO
                var paginaReemplazada = MemoriaFisica[0];
                MemoriaFisica[0] = new Pagina(nuevaPagina);
                MessageBox.Show($"Página {paginaReemplazada.Numero} reemplazada por la página {nuevaPagina}.");
            }
        }

        // Reemplazo LRU: basado en el último acceso
        public void SimularLRU(int nuevaPagina)
        {
            // Comprobar si la página está ya en la memoria física
            if (MemoriaFisica.All(p => p == null || p.Numero != nuevaPagina))
            {
                // Si no está en memoria, aplicar LRU
                ReemplazarPaginaLRU(nuevaPagina);
            }
            else
            {
                MessageBox.Show("La página ya está en memoria.");
            }
        }

        private void ReemplazarPaginaLRU(int nuevaPagina)
        {
            // Ordenar la memoria física por el último acceso
            MemoriaFisica = MemoriaFisica.OrderBy(p => p?.UltimoAcceso ?? DateTime.MinValue).ToList();

            // Reemplazar la página más antigua
            var paginaReemplazada = MemoriaFisica[0];
            MemoriaFisica[0] = new Pagina(nuevaPagina);
            MessageBox.Show($"Página {paginaReemplazada.Numero} reemplazada por la página {nuevaPagina}.");
        }
    }
}

