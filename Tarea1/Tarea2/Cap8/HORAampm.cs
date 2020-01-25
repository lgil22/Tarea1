using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea2.Cap8
{
  public class HORAampm
    {
        public void AMPM()
        {
            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.ReadKey();
        }
    }
}
