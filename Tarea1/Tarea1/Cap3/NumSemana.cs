using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea1.Cap3
{
   public class NumSemana
    {
        public void Dias()
        {
            int num;
            Console.WriteLine("\t\tIntroduzca un numero del 1-7 para determinar que dia es \n");
            num = Int32.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\nEs Domingo");
                Console.Read();
            }
            else
                if (num == 2)
            {
                Console.WriteLine("\nEs Lunes");
                Console.Read();
            }

            else
                if (num == 3)
            {
                Console.WriteLine("\nEs Martes");
                Console.Read();
            }

            else
                if (num == 4)
            {
                Console.WriteLine("\nEs Miercoles");
                Console.Read();
            }

            else
                if (num == 5)
            {
                Console.WriteLine("Es Jueves");
                Console.Read();
            }

            else
                if (num == 6)
            {
                Console.WriteLine("Es Viernes");
                Console.Read();
            }

            else
            {
                Console.WriteLine("Es Sabado");
                Console.Read();
            }
        }
    }
}
