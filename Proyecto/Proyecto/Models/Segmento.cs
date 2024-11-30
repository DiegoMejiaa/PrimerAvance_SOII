namespace Proyecto.Models
{
    // Clase para representar un segmento en la memoria
    public class Segmento
    {
        public string Nombre { get; set; }
        public int Tamaño { get; set; }
        public bool Disponible { get; set; }

        public Segmento(string nombre, int tamaño, bool disponible)
        {
            Nombre = nombre;
            Tamaño = tamaño;
            Disponible = disponible;
        }

        public override string ToString()
        {
            return $"{Nombre} - Tamaño: {Tamaño} KB - {(Disponible ? "Disponible" : "Ocupado")}";
        }
    }
}

