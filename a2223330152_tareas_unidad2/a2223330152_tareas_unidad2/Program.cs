using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_tareas_unidad2
{
    class Program
    {
        public static String[] nombres = { "Marcos", "Andrea", "Carlos", "Karla", "Melisa", "Abril", "Eduardo", "Humberto", "Adriana", "Lucia" };
        static Random random = new Random();

        static void Main(string[] args)
        {
			Cmateria materia = new Cmateria("Matematicas", 10);

			Console.Out.WriteLine("Materia: " + materia.getMateria());

			for (int i = 0; i < 10; i++)
			{
				materia.setAlumno(nombres[i], Convert.ToString(random.Next(1,100) + 1), random.Next(1,10), i);
			}

			for (int i = 0; i < 10; i++)
			{
				Console.Out.WriteLine(materia.datoAlumno(i) + "\n");
			}

			Console.Out.WriteLine("El promedio grupal es: " + materia.promedio(10));
			Console.In.ReadLine();
		}
    }
}
