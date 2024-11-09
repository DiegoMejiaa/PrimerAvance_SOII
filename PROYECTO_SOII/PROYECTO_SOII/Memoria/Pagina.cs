using System;

namespace memoria
{
    // Clase que representa una página en la memoria
    public class Pagina
    {
        private int numeroPagina;
        private bool referenciada;
        private bool modificada;

        public Pagina(int numeroPagina)
        {
            this.numeroPagina = numeroPagina;
            this.referenciada = false;
            this.modificada = false;
        }

        // Obtiene el número de la página
        public int GetNumeroPagina()
        {
            return numeroPagina;
        }

        // Obtiene o establece si la página ha sido referenciada
        public bool EstaReferenciada()
        {
            return referenciada;
        }

        public void SetReferenciada(bool referenciada)
        {
            this.referenciada = referenciada;
        }

        // Obtiene o establece si la página ha sido modificada
        public bool EstaModificada()
        {
            return modificada;
        }

        public void SetModificada(bool modificada)
        {
            this.modificada = modificada;
        }
    }
}
