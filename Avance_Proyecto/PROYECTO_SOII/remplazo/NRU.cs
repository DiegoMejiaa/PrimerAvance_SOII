using System;
using System.Collections.Generic;
using memoria;

namespace reemplazo
{
    // Implementación del algoritmo de reemplazo NRU
    public class NRU
    {
        private List<Pagina> paginas;
        private Memoria memoria;

        public NRU(Memoria memoria)
        {
            this.memoria = memoria;
            this.paginas = new List<Pagina>();
        }

        // Accede a una página, actualizando su estado según NRU
        public void AccederPagina(int numeroPagina, bool escribir)
        {
            Pagina pagina = memoria.BuscarPagina(numeroPagina);
            if (pagina != null)
            {
                pagina.SetReferenciada(true);
                if (escribir)
                {
                    pagina.SetModificada(true);
                }
            }
        }

        // Reemplaza una página en la memoria según el algoritmo NRU
        public void Reemplazar(Pagina nuevaPagina)
        {
            if (memoria.GetPaginas().Count >= memoria.GetTamaño())
            {
                Pagina paginaARemover = SeleccionarPaginaParaReemplazar();
                memoria.EliminarPagina(paginaARemover.GetNumeroPagina());
            }
            memoria.AgregarPagina(nuevaPagina);
            paginas.Add(nuevaPagina);
        }

        // Selecciona una página para reemplazar según el algoritmo NRU
        private Pagina SeleccionarPaginaParaReemplazar()
        {
            foreach (Pagina pagina in paginas)
            {
                if (!pagina.EstaReferenciada() && !pagina.EstaModificada())
                {
                    return pagina;
                }
            }
            foreach (Pagina pagina in paginas)
            {
                if (!pagina.EstaReferenciada())
                {
                    return pagina;
                }
            }
            foreach (Pagina pagina in paginas)
            {
                if (!pagina.EstaModificada())
                {
                    return pagina;
                }
            }
            return paginas[0];
        }
    }
}
