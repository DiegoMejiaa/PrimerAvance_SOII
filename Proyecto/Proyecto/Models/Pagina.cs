    using System;

    public class Pagina
    {
        public int Numero { get; set; }  // Número de la página
        public DateTime UltimoAcceso { get; set; }  // Para LRU

        public Pagina(int numero)
        {
            Numero = numero;
            UltimoAcceso = DateTime.Now;
        }
    }

