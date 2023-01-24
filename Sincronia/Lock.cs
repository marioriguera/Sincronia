using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sincronia
{
    /// <summary>
    /// Clase para el estudio de lock.
    /// </summary>
    public class Lock
    {
        /// <summary>
        /// Listado utilizado para gestionarlo por threads.
        /// </summary>
        private static List<string> ListLoks = new List<string>() { "uno", "dos", "tres", "cuatro", "cinco" };

        /// <summary>
        /// Nuevo listado utilizado para agregar numeros.
        /// </summary>
        public static List<string> NuevosElementos { get; set; } = new List<string>() { "seis", "siete", "ocho" };

        /// <summary>
        /// Principal trabajo con hilos.
        /// </summary>
        public static void TrabajoHilos()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Imprimir).Start();
                new Thread(AgregarNuevosElementos).Start();
            }
        }

        /// <summary>
        /// Impresión de elementos del listado en consola.
        /// </summary>
        private static void Imprimir()
        {
            Console.WriteLine($"Inicio de impresión. Id hilo: {Thread.CurrentThread.ManagedThreadId} .");
            lock (ListLoks)
            {
                foreach (string s in ListLoks)
                {
                    Console.WriteLine($" El numero a imprimir es: {s}");
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Fin de impresión. Id hilo: {Thread.CurrentThread.ManagedThreadId} .");
        }

        /// <summary>
        /// Agregar nuevos elementos a <see cref="ListLoks" ./>
        /// </summary>
        private static void AgregarNuevosElementos()
        {
            Console.WriteLine($"Inicio de agregar elementos. Id hilo: {Thread.CurrentThread.ManagedThreadId} .");
            lock (ListLoks)
            {
                foreach (string s in NuevosElementos)
                {
                    ListLoks.Add(s);
                }
            }
            Thread.Sleep(100);
            Console.WriteLine($"Fin de agregar elementos. Id hilo: {Thread.CurrentThread.ManagedThreadId} .");
        }
    }
}
