using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea2.Cap8
{
    public class DosCadenas
    {
        public static string[] Ordernar(string[] cadenas)
        {
            return (from c in cadenas orderby c select c).ToArray<string>();
        }
        public void cadens()
        {
            string[] cadenas = { "Joyeria", "Avion", "Responsabilidad", "Piratas" };

            Console.WriteLine("\t \t Palabras desordenadas:");
            foreach (string s in cadenas)
                Console.WriteLine(s);

            cadenas = Ordernar(cadenas);

            Console.WriteLine("\n  \t \t Palabras ordenadas:");
            foreach (string s in cadenas)
                Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
