using System;
using System.Collections.Generic;

namespace memoria
{
    public class Memoria
    {
        private int tamaño;
        private List<Pagina> paginas;
        private List<int> particionesFijas; // Para particionamiento fijo
        private bool particionamientoDinamico; // Para particionamiento dinámico

        // Constructor modificado para aceptar el tipo de particionamiento
        public Memoria(int tamaño, bool particionamientoDinamico = false)
        {
            this.tamaño = tamaño;
            this.paginas = new List<Pagina>();
            this.particionesFijas = new List<int>(); // Para particionamiento fijo
            this.particionamientoDinamico = particionamientoDinamico;

            if (!particionamientoDinamico)
            {
                // Crear particiones fijas de tamaño igual
                int numParticiones = 4; // Ajusta según sea necesario
                int tamañoParticion = tamaño / numParticiones;
                for (int i = 0; i < numParticiones; i++)
                {
                    particionesFijas.Add(tamañoParticion);
                }
            }
        }

        // Método para agregar una página en memoria
        public void AgregarPagina(Pagina pagina)
        {
            if (particionamientoDinamico)
            {
                if (paginas.Count >= tamaño)
                {
                    throw new OutOfMemoryException("No hay suficiente espacio en la memoria.");
                }
                paginas.Add(pagina);
            }
            else
            {
                // En particionamiento fijo, se asigna a una partición disponible
                foreach (var particion in particionesFijas)
                {
                    if (paginas.Count < particion)
                    {
                        paginas.Add(pagina);
                        return;
                    }
                }
                throw new OutOfMemoryException("No hay suficiente espacio en la memoria.");
            }
        }

        // Método para eliminar una página en memoria
        public void EliminarPagina(int numeroPagina)
        {
            paginas.RemoveAll(pagina => pagina.GetNumeroPagina() == numeroPagina);
        }

        // Método para buscar una página en memoria
        public Pagina BuscarPagina(int numeroPagina)
        {
            return paginas.Find(pagina => pagina.GetNumeroPagina() == numeroPagina);
        }

        // Obtener la lista de páginas
        public List<Pagina> GetPaginas()
        {
            return paginas;
        }

        // Obtener tamaño de memoria
        public int GetTamaño()
        {
            return tamaño;
        }
    }
}