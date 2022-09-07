using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad01_Tarea02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpersona cantante1, cantante2, actor1;

            cantante1 = new Cpersona("Jose Alfredo Jimenez", "canta");
            actor1 = new Cpersona("Joaquín Cosío Osuna", "actua");
            cantante2 = new Cpersona("Pedro Infante", "canta");
            Console.WriteLine(cantante1.toString());
            Console.WriteLine(cantante2.toString());
            Console.WriteLine(actor1.toString());

            Console.ReadKey();
        }
    }
}
