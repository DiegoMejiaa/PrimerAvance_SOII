using System;
using System.Collections.Generic;
using memoria;
using reemplazo;

public class SimuladorMemoriaVirtual
{
    private Memoria memoria;
    private object algoritmoReemplazo;
    private int fallosPagina;
    private Dictionary<int, int> tablaPaginas;  // Simula la tabla de páginas

    public SimuladorMemoriaVirtual(int tamañoMemoria, string algoritmo)
    {
        this.memoria = new Memoria(tamañoMemoria);
        this.tablaPaginas = new Dictionary<int, int>();
        switch (algoritmo)
        {
            case "FIFO":
                this.algoritmoReemplazo = new FIFO(memoria);
                break;
            case "LRU":
                this.algoritmoReemplazo = new LRU(memoria);
                break;
            case "NRU":
                this.algoritmoReemplazo = new NRU(memoria);
                break;
            default:
                throw new ArgumentException("Algoritmo no soportado.");
        }
        this.fallosPagina = 0;
    }

    // Método para acceder a una página y devolver la dirección física
    public int AccederPagina(int numeroPaginaVirtual, bool escribir)
    {
        int numeroPaginaFisica;

        // Verifica si la página virtual está en la tabla de páginas (traducción de dirección)
        if (tablaPaginas.ContainsKey(numeroPaginaVirtual))
        {
            // Página encontrada en la tabla de páginas, obtener el número de página física
            numeroPaginaFisica = tablaPaginas[numeroPaginaVirtual];
        }
        else
        {
            // Página no encontrada en la tabla de páginas (fallo de página)
            fallosPagina++;
            numeroPaginaFisica = memoria.GetPaginas().Count;

            // Crear una nueva instancia de la página
            Pagina nuevaPagina = new Pagina(numeroPaginaVirtual);

            // Reemplazar una página existente usando el algoritmo seleccionado
            if (algoritmoReemplazo is FIFO)
            {
                ((FIFO)algoritmoReemplazo).Reemplazar(nuevaPagina);
            }
            else if (algoritmoReemplazo is LRU)
            {
                ((LRU)algoritmoReemplazo).Reemplazar(nuevaPagina);
            }
            else if (algoritmoReemplazo is NRU)
            {
                ((NRU)algoritmoReemplazo).Reemplazar(nuevaPagina);
            }

            // Actualizar la tabla de páginas con la nueva página
            tablaPaginas[numeroPaginaVirtual] = numeroPaginaFisica;
        }

        // Obtener la página de la memoria física
        Pagina pagina = memoria.BuscarPagina(numeroPaginaVirtual);

        if (pagina != null)
        {
            // Actualizar la página según el algoritmo de reemplazo
            if (algoritmoReemplazo is LRU)
            {
                ((LRU)algoritmoReemplazo).AccederPagina(numeroPaginaVirtual);
            }
            else if (algoritmoReemplazo is NRU)
            {
                ((NRU)algoritmoReemplazo).AccederPagina(numeroPaginaVirtual, escribir);
            }
        }

        // Devolver el número de página física (dirección física)
        return numeroPaginaFisica;
    }

    public int GetFallosPagina()
    {
        return fallosPagina;
    }

    public static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la memoria física: ");
        int tamañoMemoria = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el algoritmo de reemplazo (FIFO, LRU, NRU): ");
        string algoritmo = Console.ReadLine();

        SimuladorMemoriaVirtual simulador = new SimuladorMemoriaVirtual(tamañoMemoria, algoritmo);

        while (true)
        {
            Console.Write("Ingrese la operación (acceso o fin): ");
            string operacion = Console.ReadLine();
            if (operacion.Equals("fin", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            Console.Write("Ingrese el número de página virtual: ");
            int numeroPaginaVirtual = int.Parse(Console.ReadLine());
            Console.Write("¿Es una operación de escritura? (si/no): ");
            bool escribir = Console.ReadLine().Equals("si", StringComparison.OrdinalIgnoreCase);

            // Realizar el acceso a la página y obtener la dirección física
            int direccionFisica = simulador.AccederPagina(numeroPaginaVirtual, escribir);

            // Mostrar la dirección física resultante
            Console.WriteLine("Dirección física: " + direccionFisica);
        }

        Console.WriteLine("Fallos de página: " + simulador.GetFallosPagina());
    }
}
