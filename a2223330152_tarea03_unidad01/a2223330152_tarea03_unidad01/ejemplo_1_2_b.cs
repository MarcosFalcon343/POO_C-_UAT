using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace a2223330152_tarea03_unidad01
{
    class ejemplo_1_2_b
    {

        static void Main(string[] args)
        {
            Cpersona cantantel, cantante2, actor1;

            cantantel = new Cpersona("Jose Alfredo Jimenez", "canta");
            actor1 = new Cpersona("Joaquín Cosío Osuna", "actua");
            cantante2 = new Cpersona("José Pedro Infante Cruz", "Canta Amorcito corazon");
            Console.Out.WriteLine(cantantel.toString());
            Console.Out.WriteLine(cantante2.toString());
            Console.Out.WriteLine(actor1.toString());
            Console.In.ReadLine(); // es necesario para poder observar el resultado
        }
    }
}
