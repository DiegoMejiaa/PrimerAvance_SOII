
using System.Linq;
using System.Collections.Generic;

namespace Proyecto.Models
{
    public class Memoria
    {
        public int TamañoTotal { get; set; } // Tamaño total de la memoria
        public List<BloqueMemoria> Bloques { get; set; } // Lista de bloques de memoria
        public List<Proceso> ProcesosAsignados { get; set; } // Procesos asignados

        public Memoria(int tamañoTotal, int cantidadBloques)
        {
            TamañoTotal = tamañoTotal;
            Bloques = new List<BloqueMemoria>();
            for (int i = 0; i < cantidadBloques; i++)
            {
                Bloques.Add(new BloqueMemoria(i + 1, tamañoTotal / cantidadBloques)); // Asignación equitativa de memoria
            }
            ProcesosAsignados = new List<Proceso>();
        }

        // Método para asignar un proceso
        public string AsignarProceso(int tamañoProceso)
        {
            foreach (var bloque in Bloques)
            {
                if (bloque.EstaLibre && bloque.Tamaño >= tamañoProceso)
                {
                    bloque.AsignarProceso(tamañoProceso);
                    ProcesosAsignados.Add(new Proceso(tamañoProceso, bloque.Id));
                    return $"Proceso de tamaño {tamañoProceso} asignado al bloque {bloque.Id}.";
                }
            }

            return "No hay bloques libres o suficientemente grandes para el proceso.";
        }

        // Método para liberar un bloque
        public string LiberarBloque(int bloqueId)
        {
            var bloque = Bloques.FirstOrDefault(b => b.Id == bloqueId);
            if (bloque != null)
            {
                bloque.Liberar();
                ProcesosAsignados.RemoveAll(p => p.BloqueId == bloqueId);
                return $"Bloque {bloqueId} liberado exitosamente.";
            }
            return $"El bloque {bloqueId} no existe o ya está libre.";
        }

        // Obtener el estado actual de la memoria
        public string ObtenerEstadoMemoria()
        {
            var estado = "";
            foreach (var bloque in Bloques)
            {
                estado += $"Bloque {bloque.Id}: {(bloque.EstaLibre ? " Libre " : $"Ocupado por Proceso de tamaño {bloque.ProcesoTamaño}")}";
            }
            return estado;
        }
    }

    public class BloqueMemoria
    {
        public int Id { get; set; }
        public int Tamaño { get; set; }
        public bool EstaLibre { get; set; }
        public int ProcesoTamaño { get; set; }

        public BloqueMemoria(int id, int tamaño)
        {
            Id = id;
            Tamaño = tamaño;
            EstaLibre = true;
        }

        public void AsignarProceso(int tamañoProceso)
        {
            if (EstaLibre && tamañoProceso <= Tamaño)
            {
                EstaLibre = false;
                ProcesoTamaño = tamañoProceso;
            }
        }

        public void Liberar()
        {
            EstaLibre = true;
            ProcesoTamaño = 0;
        }
    }

    public class Proceso
    {
        public int Tamaño { get; set; }
        public int BloqueId { get; set; }

        public Proceso(int tamaño, int bloqueId)
        {
            Tamaño = tamaño;
            BloqueId = bloqueId;
        }
    }
}
