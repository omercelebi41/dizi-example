using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcı dizinin sınırını belirlicek, dizi random dolucak,aynı diziyi tersten doldurcaz.
            int a = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[a];
            Random r = new Random();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(100);
                Console.WriteLine(d[i]);
            }
            Console.WriteLine("---------------------");
                  
            for (int i = 0; i < d.Length/2; i++)
            {
                int ge = d[d.Length - 1 - i];
                d[d.Length - 1 - i] = d[i];
                d[i] = ge;
            }
            foreach (int x  in d)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
