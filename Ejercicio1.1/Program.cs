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
            int Opcion;
            Capitulo1 p1 = new Capitulo1();
            capitulo2 p2 = new capitulo2();
            Capitulo3 p3 = new Capitulo3();
            Capitulo4 p4 = new Capitulo4();

            Console.WriteLine("*********************menu*****************************");
            Console.WriteLine("*---capitulo1----------------------------------------*");
            Console.WriteLine("* 1   Tabla de multipliacion1.1:                     *");
            Console.WriteLine("* 2   _1.5:                                          *");
            Console.WriteLine("*---capitulo2:---------------------------------------*");
            Console.WriteLine("*3    calculo de cualquier poligono_2.1:             *");
            Console.WriteLine("*4    Converciond e grados a Radianes_2.3:           *");
            Console.WriteLine("*5    Convercion de dolares a Euros y viseversa_2.5: *");
            Console.WriteLine("*---capitulo3----------------------------------------*");
            Console.WriteLine("*6    Numeros pares o impares_3.1:                   *");
            Console.WriteLine("*7    numeracion de los dias de la semana_3.4:       *");
            Console.WriteLine("*8    calculo de poligono_1.5:                       *");
            Console.WriteLine("*---capitulo4----------------------------------------*");
            Console.WriteLine("*9     tabla de multiplicacion_4.1:                  *");
            Console.WriteLine("*10    Elevar numeros acualquier potencia_4.2:       *");
            Console.WriteLine("*11    Promedio de edad_4.5:                         *");

            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                   
                    p1.ejercicio1();
                    Console.ReadKey();
                    break;
                case 2: p1.ejercicio5();
                    Console.ReadKey();
                    break;
                case 3:
                    p2.ejercicios1();
                    Console.ReadKey();
                    break;
                case 4:
                    p2.Ejercicos3()
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
               

            }

        }
    }
}
