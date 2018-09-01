using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
   class Capitulo1
    {
    
        public void menu()
        {
            int opcion;

            Console.WriteLine("\nEjercicio del captilo 1");
            Console.WriteLine("\n1.Ejercicio1");
            Console.WriteLine("\n2.Ejercicio5");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    ejercicio1();

                    break;
                case 2:
                    Console.Clear();
                    ejercicio5();
                    break;
            }


        }

        public void ejercicio1()
        {
            Console.WriteLine("reydi alejandro");
            Console.ReadKey();
        }

        public void ejercicio5()
        {
            Console.WriteLine("reydi alejandro");
            Console.WriteLine("Mendez Suarez");
            Console.WriteLine("2016-0582");
            Console.WriteLine("Estudiante ing sistema");
            Console.ReadKey();

        }
    }
}
