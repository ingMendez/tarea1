using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    class Capitulo3
    {
        public void ejercicio3_1()
        {
            float n,m;
            Console.WriteLine("digite un numero");
            n = Convert.ToSingle(Console.ReadLine());

            if(n %2 == 0)
            {
                Console.WriteLine("es par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("no es par");
                Console.ReadKey();
            }
        }
        public void Ejercicios3_4()
        {
            int n;
            Console.WriteLine("digite el el numero del 1 hasta el 7");
            n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Console.WriteLine("domingo");
                        Console.ReadKey();
                        break;
                    case 2:Console.WriteLine("lunes");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Martes");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Miercoles");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("jueves");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("viernes");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("sabado");
                        Console.ReadKey();
                        break;

                }
        }

        public void ejercicio3_5()
        { /* Hacer una programa que pueda calcular 
             * el perímetro y el área de cualquier polígono regular,
             * pero que le pregunte al usuario qué desea calcular.
             */

        }


    }

}

