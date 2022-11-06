using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '}')
                        {
                            s = s.Substring(0, i) + s.Substring(j + 1);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
