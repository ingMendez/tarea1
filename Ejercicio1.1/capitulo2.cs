using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    class capitulo2
    {

        public void ejercicios1()
        {
            int lado;
            float l;
            Console.WriteLine("digite lo lados del poligono");
            lado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("logitud de un lado es :");
            l = Convert.ToSingle(Console.ReadLine());
            float total;
            total = lado *l;
            Console.WriteLine("el perimetro es: "+ total);
            Console.ReadKey();
        }

        public void ejercicos3()
        {
            float grados;
            Console.WriteLine("numero en grados");
            grados = Convert.ToSingle(Console.ReadLine());

            float radian;

            radian = grados * ((float)Math.PI / 180);
            Console.WriteLine("la convercion a radieanes es :" + radian);

        }
        public void ejercicios5()
        {
            int opcion;
            float dolares,euros,taza,cambio;

            Console.WriteLine("\n1.dolares a euro");
            Console.WriteLine("\n1.euros");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("digite cantidad de dolares:");
                    dolares = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("taza de euros:");
                    taza = Convert.ToSingle(Console.ReadLine());
                    cambio = dolares / taza;
                   Console.WriteLine("el cambio en euros es de:" + cambio + ":\t euros");
                    Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("digite cantidad de euros:");
                    dolares = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("taza del dolar:");
                    taza = Convert.ToSingle(Console.ReadLine());
                    cambio = dolares / taza;

                    Console.WriteLine("el cambio en dolar es de:" + cambio + ":\tdolares");
                    Console.ReadKey();
                    break;
            }

        }
    }
} 