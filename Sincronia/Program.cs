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
            Console.WriteLine("Pruebas de sincronía.");

            // Trabajos con lock.
            Lock.TrabajoHilos();

            Console.ReadKey();
        }
    }
}