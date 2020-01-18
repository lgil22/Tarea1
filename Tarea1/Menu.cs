using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1;

namespace Tarea1
{
   public class Menu
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.Write("1.Ejercicios Capitulo #1\n" + "2.Ejercicios Capitulo #2\n" + "3.Ejercicios Capitulo #3\n" + "4.Ejercicios Capitulo #4\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Menu1();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Menu2();
                        break;
                    case 3:
                        Console.Clear();
                        Menu3();
                        break;
                    case 4:
                        Console.Clear();
                        Menu4();
                        break;
                }

            }
        }
        public static void Menu1()
        {
            Console.Clear();
            Console.Write("1.Ejercicio 1: Nombre Propio\n" + "2.Ejercicio 2: String\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea1.Cap1.Nombre Nomb = new Tarea1.Cap1.Nombre();
                        Nomb.Nomb();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea1.Cap1.Nombre2 mensj = new Tarea1.Cap1.Nombre2();
                        mensj.Mensajes();
                        break;
                }
            }

        }

        public static void Menu2()
        {
            Console.Write("1.Ejercicio 1: Cambio Dolar a Euro\n" + "2.Ejercicio 2:Grados a Radianes\n" + "3.Ejercicio 3: Poligono Regular\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea1.Cap2.CambioDolarEuro camb = new Tarea1.Cap2.CambioDolarEuro();
                        camb.Cambio();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea1.Cap2.GradosRadianes grad = new Tarea1.Cap2.GradosRadianes();
                        grad.Conversion();
                        break;
                    case 3:
                        Console.Clear();
                        Tarea1.Cap2.PoligonoRegular pog = new Tarea1.Cap2.PoligonoRegular();
                        pog.PoligR();
                        break;
                }

            }
        }

        public static void Menu3()
        {
            Console.Write("1.Ejercicio 1: Area y Perimetro\n" + "2.Ejercicio 2:Numero Semana\n" + "3.Ejercicio 3:Numero Par o Impar\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea1.Cap3.AreaPerimetro area = new Tarea1.Cap3.AreaPerimetro();
                        area.Opcion();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea1.Cap3.NumSemana semana = new Tarea1.Cap3.NumSemana();
                        semana.Dias();
                        break;
                    case 3:
                        Console.Clear();
                        Tarea1.Cap3.ParImpar par = new Tarea1.Cap3.ParImpar();
                        par.parImp();
                        Console.Read();
                        break;
                }

            }
        }

        public static void Menu4()
        {
            Console.Write("1.Ejercicio 1: Edad Promedio\n" + "2.Ejercicio 2: Tabla Multiplicacion 1-10\n" + "3.Ejercicio 3:Elevacion a la Potencia\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea1.Cap4.EdadPromedio edad = new Tarea1.Cap4.EdadPromedio();
                        edad.Prom();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea1.Cap4.Mult mult = new Tarea1.Cap4.Mult();
                        mult.tabMult();
                        break;
                    case 3:
                        Console.Clear();
                        Tarea1.Cap4.Potencia pot = new Tarea1.Cap4.Potencia();
                        pot.Elevado();
                        break;
                }

            }
        }
    }
}
