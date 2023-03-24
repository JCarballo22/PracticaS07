using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();
            Console.WriteLine("Por Favor ingrese una raza de perro ");
            //perro.setRaza(Console.ReadLine());
            perro.Raza = Console.ReadLine();
            //Console.WriteLine(perro.getRaza());
            Console.WriteLine(perro.Raza);
            Console.ReadKey();

        }
    }
}
