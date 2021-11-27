using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Array In C# .

            int[] Intes = new int[] { 1, 2, 3 };
           //  Intes[3] = 99; False Output .

            // Array Lists In C# .

            ArrayList Ages = new ArrayList();
            Ages.Add(1);
            Ages.Add(2);
            Ages.Add(3);
            Ages.Add(4);


            foreach (var age in Ages)
                Console.Write(age);
        }
    }
}
