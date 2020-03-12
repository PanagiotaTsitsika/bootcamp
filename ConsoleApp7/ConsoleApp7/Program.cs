using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static string Likes(string[]names)
        {
            if(names.Length == 0)
            {
                return "No one likes this";
            }
            else if(names.Length == 1)
            {
                return $"{names[0]} like this";
            }
            else if(names.Length == 2)
            {
                return $"{names[0]} and {names[1]} like this";
            }
            else if(names.Length == 3)
            {
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            else
            {
                return $"{names[0]}, {names[1]} and {names.Length - 2} like this";
            }

        }
        static void Main(string[] args)
        {
            string[] names = { "Nick", "Alex", "Maria", "Marios"};
            Console.WriteLine(Likes(names));
        }
    }
}
