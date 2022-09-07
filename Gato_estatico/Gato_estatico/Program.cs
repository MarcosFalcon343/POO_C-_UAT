using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato_estatico
{
    class Program
    {
		static char[] c1;
		static char[] c2;
		static char[] c3;
		static int contador;

		static char jugador;

		public static void Main(String[] args)
		{
			String sfila, scolumna;

			inicializar();
			bool ganador = false;

			while ((contador < 9) && (!ganador))
			{
				Console.WriteLine("Jugador ->" + jugador);
				Console.WriteLine(mensaje());
				Console.WriteLine("Introduce que fila[1..3]");
				sfila = Console.ReadLine();
				Console.WriteLine("Introduce que columna[1..3]");
				scolumna = Console.ReadLine();
				Console.Clear();

				if (introducir(jugador, sfila, scolumna))
				{
					if (!evaluarHorizontal(jugador))
					{
						contador++;
						switch (jugador)
						{
							case '1': jugador = '2'; break;
							case '2': jugador = '1'; break;
						}
					}
					else ganador = true;
				}//Fin introducir
			}//Fin ciclo While

			if (ganador) Console.WriteLine("Ha ganado el jugador " + jugador);
			else Console.WriteLine("No hubo ganador");
			Console.WriteLine(mensaje());

			Console.ReadKey();
		}

		public static void inicializar()
		{
			jugador = '1';
			c1 = new char[3];
			c2 = new char[3];
			c3 = new char[3];
			for (int i = 0; i < 3; i++)
			{
				c1[i] = '0';
				c2[i] = '0';
				c3[i] = '0';
			}
			contador = 0;
		}

		public static String mensaje()
		{
			String cadena = c1[0] + " " + c2[0] + " " + c3[0] + " " + "\n";
			cadena = cadena + c1[1] + " " + c2[1] + " " + c3[1] + " " + "\n";
			cadena = cadena + c1[2] + " " + c2[2] + " " + c3[2] + " " + "\n";

			return cadena;
		}

		public static bool introducir(char jugador, String Fila, String Columna)
		{
			int fila = int.Parse(Fila);
			int columna = int.Parse(Columna);
			bool exito = true;

			switch (columna)
			{
				case 1:
					if (c1[fila - 1] == '0') c1[fila - 1] = jugador;
					else
					{
						Console.WriteLine("Esta ocupado");
						exito = false;
					}
					break;
				case 2:
					if (c2[fila - 1] == '0') c2[fila - 1] = jugador;
					else
					{
						Console.WriteLine("Esta ocupado");
						exito = false;
					}
					break;
				case 3:
					if (c3[fila - 1] == '0') c3[fila - 1] = jugador;
					else
					{
						Console.WriteLine("Esta ocupado");
						exito = false;
					}
					break;
			}
			return exito;
		}

		public static bool evaluarHorizontal(char jugador)
		{
			bool exito = false;
			if ((c1[0] == jugador) && (c1[1] == jugador) && (c1[2] == jugador)) exito = true;
			if ((c2[0] == jugador) && (c2[1] == jugador) && (c2[2] == jugador)) exito = true;
			if ((c3[0] == jugador) && (c3[1] == jugador) && (c3[2] == jugador)) exito = true;

			return exito;
		}
	}
}
