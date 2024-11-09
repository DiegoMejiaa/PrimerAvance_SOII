using System;
using memoria;

public class SimuladorMemoriaVirtual
{
    private Memoria memoria;
    private int fallosPagina;
    private Dictionary<int, int> tablaPaginas;

    // Constructor modificado para aceptar particionamiento
    public SimuladorMemoriaVirtual(int tamañoMemoria, bool particionamientoDinamico)
    {
        memoria = new Memoria(tamañoMemoria, particionamientoDinamico);
        tablaPaginas = new Dictionary<int, int>();
        fallosPagina = 0;
    }

    public int AccederPagina(int numeroPaginaVirtual, bool escribir)
    {
        int numeroPaginaFisica;

        // Verifica si la página virtual está en la tabla de páginas (traducción de dirección)
        if (tablaPaginas.ContainsKey(numeroPaginaVirtual))
        {
            numeroPaginaFisica = tablaPaginas[numeroPaginaVirtual];
        }
        else
        {
            fallosPagina++;
            numeroPaginaFisica = memoria.GetPaginas().Count;

            // Crear una nueva página
            Pagina nuevaPagina = new Pagina(numeroPaginaVirtual);
            memoria.AgregarPagina(nuevaPagina);
            tablaPaginas[numeroPaginaVirtual] = numeroPaginaFisica;
        }

        // Devolver la dirección física
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
        Console.Write("Seleccione el tipo de particionamiento (fijo/dinamico): ");
        string particionamiento = Console.ReadLine().ToLower();
        bool particionamientoDinamico = particionamiento == "dinamico";

        SimuladorMemoriaVirtual simulador = new SimuladorMemoriaVirtual(tamañoMemoria, particionamientoDinamico);

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