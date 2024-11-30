using System;
using System.Collections.Generic;

namespace memoria
{
    // Clase que representa la memoria física del sistema
    public class Memoria
    {
        private int tamaño;
        private List<Pagina> paginas;

        public Memoria(int tamaño)
        {
            this.tamaño = tamaño;
            this.paginas = new List<Pagina>();
        }

        // Agrega una página a la memoria
        public void AgregarPagina(Pagina pagina)
        {
            if (paginas.Count >= tamaño)
            {
                throw new OutOfMemoryException("No hay suficiente espacio en la memoria.");
            }
            paginas.Add(pagina);
        }

        // Elimina una página de la memoria por su número de página
        public void EliminarPagina(int numeroPagina)
        {
            paginas.RemoveAll(pagina => pagina.GetNumeroPagina() == numeroPagina);
        }

        // Busca una página en la memoria por su número de página
        public Pagina BuscarPagina(int numeroPagina)
        {
            return paginas.Find(pagina => pagina.GetNumeroPagina() == numeroPagina);
        }

        // Obtiene la lista de páginas en la memoria
        public List<Pagina> GetPaginas()
        {
            return paginas;
        }

        // Obtiene el tamaño de la memoria
        public int GetTamaño()
        {
            return tamaño;
        }
    }
}
