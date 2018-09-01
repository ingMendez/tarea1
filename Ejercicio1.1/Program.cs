using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int Opcion;
            Capitulo1 p1 = new Capitulo1();
            capitulo2 p2 = new capitulo2();
            Capitulo3 p3 = new Capitulo3();
            Capitulo4 p4 = new Capitulo4();

            p1.menu();
            Opcion = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (Opcion)
                {
                    case 1:

                        p1.ejercicio1();
                        Console.ReadKey();

                        break;
                    case 2:
                        p1.menu();
                        p1.ejercicio5();
                        Console.ReadKey();
                        break;
                    case 3:
                        p2.ejercicios1();
                        Console.ReadKey();
                        break;
                    case 4:
                        p2.Ejercicos3();
                        Console.ReadKey();
                        break;
                    case 5:
                        p2.ejercicios5();
                        Console.ReadKey();
                        break;
                    case 6:
                        p3.ejercicio3_1();
                        Console.ReadKey();
                        break;
                    case 7:
                        p3.Ejercicios3_4();
                        Console.ReadKey();
                        break;
                    case 8:
                        p3.ejercicio3_5();
                        break;
                    case 9:
                        p4.Ejercicio4_1();
                        Console.ReadKey();
                        break;
                    case 10:
                        p4.ejercicios4_2();
                        Console.ReadKey();
                        break;
                    case 11:
                        p4.ejercicios4_5();
                        Console.ReadKey();
                        break;

                   // case 12: default: break;
                }
              

                Console.WriteLine("desea salir del programa ponga 1");
                n = Convert.ToInt32(Console.ReadLine());

            } while(n !=1);

        }
    }
}
