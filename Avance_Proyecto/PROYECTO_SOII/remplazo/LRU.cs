using System;
using System.Collections.Generic;
using memoria;

namespace reemplazo
{
    // Implementación del algoritmo de reemplazo LRU
    public class LRU
    {
        private LinkedList<Pagina> lista;
        private Memoria memoria;

        public LRU(Memoria memoria)
        {
            this.memoria = memoria;
            this.lista = new LinkedList<Pagina>();
        }

        // Accede a una página, actualizando su posición en la lista según LRU
        public void AccederPagina(int numeroPagina)
        {
            Pagina pagina = memoria.BuscarPagina(numeroPagina);
            if (pagina != null)
            {
                lista.Remove(pagina);
                lista.AddFirst(pagina);
            }
        }

        // Reemplaza una página en la memoria según el algoritmo LRU
        public void Reemplazar(Pagina nuevaPagina)
        {
            if (memoria.GetPaginas().Count >= memoria.GetTamaño())
            {
                Pagina paginaARemover = lista.Last.Value;
                memoria.EliminarPagina(paginaARemover.GetNumeroPagina());
                lista.RemoveLast();
            }
            memoria.AgregarPagina(nuevaPagina);
            lista.AddFirst(nuevaPagina);
        }
    }
}
