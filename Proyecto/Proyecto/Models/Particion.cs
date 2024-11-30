namespace Proyecto
{
    public class Particion
    {
        public int Tamaño { get; set; }
        public string Estado { get; set; } // "Disponible" o "Ocupada"
        public Proceso ProcesoAsignado { get; set; }
        public int EspacioRestante { get; set; }

        public Particion(int tamaño)
        {
            Tamaño = tamaño;
            Estado = "Disponible";  // Estado inicial es disponible
            ProcesoAsignado = null;
            EspacioRestante = tamaño;
        }

        // Asignar un proceso a la partición
        public bool AsignarProceso(Proceso proceso)
        {
            if (EspacioRestante >= proceso.Tamaño)
            {
                ProcesoAsignado = proceso;
                EspacioRestante -= proceso.Tamaño; // Se reduce el espacio restante
                Estado = "Ocupada";
                return true;
            }
            return false;
        }

        // Liberar la partición
        public void Liberar()
        {
            ProcesoAsignado = null;
            EspacioRestante = Tamaño;
            Estado = "Disponible";
        }
    }
}
