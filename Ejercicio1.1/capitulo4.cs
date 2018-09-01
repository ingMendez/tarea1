using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    class Capitulo4
    {
        public void Ejercicio4_1()
        {
            int n;
            int t=0;
            Console.WriteLine("digite el numero a multiplicar");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                t = n* i;
                Console.WriteLine("n x" + i + "\t =" + t);
            }
            Console.ReadKey();
        }

        public void ejercicios4_2()
        {
            int n;
            int p;

            Console.WriteLine("digite el numero  elevar");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite el numero de elavacion");
            p = Convert.ToInt32(Console.ReadLine());

            int res;
            res = (int)Math.Pow(n, p);
            Console.WriteLine("digite el numero de elavacion"+res);
            Console.ReadKey();
        }

        public void ejercicios4_5()
        {
            int n;
            int ed,i=0;
            int x = 0;
            Console.WriteLine("digite el numero de edad:");
            n = Convert.ToInt32(Console.ReadLine());
            
            while(n != null)
            {
                i++;   
                Console.WriteLine("edad"+i);
                ed = Convert.ToInt32(Console.ReadLine());
                n--;
                Console.ReadKey();

                
            }
          
        
        }
        }
    }

