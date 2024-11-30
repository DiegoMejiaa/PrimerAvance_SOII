using System;
using System.Collections.Generic;
using memoria;

namespace reemplazo
{
    // Implementación del algoritmo de reemplazo FIFO
    public class FIFO
    {
        private Queue<Pagina> cola;
        private Memoria memoria;

        public FIFO(Memoria memoria)
        {
            this.memoria = memoria;
            this.cola = new Queue<Pagina>();
        }

        // Reemplaza una página en la memoria según el algoritmo FIFO
        public void Reemplazar(Pagina nuevaPagina)
        {
            if (memoria.GetPaginas().Count >= memoria.GetTamaño())
            {
                Pagina paginaARemover = cola.Dequeue();
                memoria.EliminarPagina(paginaARemover.GetNumeroPagina());
            }
            memoria.AgregarPagina(nuevaPagina);
            cola.Enqueue(nuevaPagina);
        }
    }
}
