namespace Sincronia
{
    /// <summary>
    /// Clase principal.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Inicio del programa.
        /// </summary>
        /// <param name="args">Argumentos.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Pruebas de sincronía.\n");

            // Trabajos con lock.
            Console.WriteLine("Trabajos con lock.\n");
            Lock.TrabajoHilos();
            Thread.Sleep(10000);

            Console.WriteLine("\n");

            // Trabajos con monitor.
            Console.WriteLine("Trabajos con monitor.\n");
            Monitor.TrabajoHilos();
            Thread.Sleep(10000);

            Console.ReadKey();
        }
    }
}