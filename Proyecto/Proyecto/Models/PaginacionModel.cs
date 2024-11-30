using System.Collections.Generic;
using System;

namespace Proyecto.Models
{
    public class PaginacionModel<T>
    {
        public List<T> Items { get; private set; }
        public int ItemsPorPagina { get; private set; }
        public int PaginaActual { get; private set; }
        public int TotalPaginas => (int)Math.Ceiling((double)Items.Count / ItemsPorPagina);

        public PaginacionModel(List<T> items, int itemsPorPagina)
        {
            Items = items;
            ItemsPorPagina = itemsPorPagina;
            PaginaActual = 1; // Comienza desde la página 1
        }

        // Obtener los elementos que se deben mostrar en la página actual
        public List<T> ObtenerItemsDePaginaActual()
        {
            int inicio = (PaginaActual - 1) * ItemsPorPagina;
            int fin = Math.Min(inicio + ItemsPorPagina, Items.Count);
            return Items.GetRange(inicio, fin - inicio);
        }

        // Cambiar a la siguiente página
        public bool SiguientePagina()
        {
            if (PaginaActual < TotalPaginas)
            {
                PaginaActual++;
                return true;
            }
            return false;
        }

        // Cambiar a la página anterior
        public bool PaginaAnterior()
        {
            if (PaginaActual > 1)
            {
                PaginaActual--;
                return true;
            }
            return false;
        }
    }
}
