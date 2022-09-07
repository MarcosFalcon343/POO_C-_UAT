using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_estudiodecasoclaseC
{
    class Program
    {
		static Concepto1[,] listaconceptos;
		static Proyecto1 proyecto;
		static double[] sumassegmento;
		static int posmanodeobra, posmaquinaria, posmateriales, posservicios;
		static double subtotal;

		public static void inicializar(){

			double incremento, iva, margenganancia;
			sumassegmento = new double[4];
			listaconceptos = new Concepto1[4,3];
			posmateriales = -1;
			posmaquinaria = -1;
			posservicios = -1;
			posmanodeobra = -1;

		
			Console.WriteLine(" Introduce porcentaje de IVA ");
			iva = double.Parse(Console.ReadLine());
			Console.WriteLine(" Introduce el porcentaje incremento de precios ");
			incremento = double.Parse(Console.ReadLine());
			Console.WriteLine(" Introduce el margen de ganancia ");
			margenganancia = double.Parse(Console.ReadLine());

			proyecto = new Proyecto1(iva, incremento, margenganancia);

		}

		public static void capturarconceptos(int n, String textoc, int pos)
		{
			String concepto,umedida;
			double precio,cantidad;
			Concepto1 nodo;

			
			Console.WriteLine("Introduce el concepto " + (pos + 1) + " de " + textoc);
			concepto = Console.ReadLine();
			Console.WriteLine("Introduce la unidad de medida de " + concepto);
			umedida = Console.ReadLine();
			Console.WriteLine("Introduce el precio " + concepto);
			precio = double.Parse(Console.ReadLine());
			Console.WriteLine("Introduce la cantidad " + concepto);
			cantidad = double.Parse(Console.ReadLine());
			nodo = new Concepto1(concepto, umedida, precio, cantidad);
			listaconceptos[n,pos] = nodo;
		}

		public static void subtotales(int pos, String textoc, int tipo)
		{
			int ciclo;
			double sumas;
			Concepto1 nodo;
			sumas = 0;
			for (ciclo = 0; ciclo <= 3; ciclo++)
				if (ciclo <= pos)
				{
					nodo = listaconceptos[tipo,ciclo];
					Console.WriteLine(nodo.getMostrartotalconcepto());
					sumas = sumas + nodo.getTotalconcepto();
				}

			if ((ciclo > -1))
			{
				sumassegmento[tipo] = sumas;
				subtotal = subtotal + sumassegmento[tipo];
				Console.WriteLine("El total del " + textoc + " fue ---->  " + sumassegmento[tipo]);
			}

		}

		public static void Main(String[] args)
        {
			double subtotalobra, tiva, total;
			String op;
			int opmenu;
			inicializar();
			opmenu = 0;

			while((opmenu != 6))
            {
				Console.WriteLine("1.- Material ");
				Console.WriteLine("2.- Mano de obra ");
				Console.WriteLine("3.- Maquinaria ");
				Console.WriteLine("4.- Servicios ");
				Console.WriteLine("5.- Reporte ");
				Console.WriteLine("6.- Salida ");
				Console.WriteLine("Que opcion deseas [1...6]");
				opmenu = int.Parse(Console.ReadLine());

                switch (opmenu)
                {
					case 1:
						op = "s";
						while ((posmateriales < 2) && ((op.Equals("s")) || (op.Equals("S"))))
						{
							Console.WriteLine("Deseas agregar concepto de material [S/N]");
							op = Console.ReadLine();
							if ((op.Equals("S")) || (op.Equals("s")))
							{
								posmateriales = posmateriales + 1;
								capturarconceptos(0, "Maerial", posmateriales);
							}
						}
						break;

					case 2:
						op = "s";
						while ((posmanodeobra < 2) && ((op.Equals("s")) || (op.Equals("S"))))
						{
							Console.WriteLine("Deseas agregar concepto de material [S/N]");
							op = Console.ReadLine();
							if ((op.Equals("S")) || (op.Equals("s")))
							{
								posmanodeobra++;
								capturarconceptos(1, "Mano de Obra", posmanodeobra);
							}
						}
						break;

					case 3:
						op = "s";
						while ((posmanodeobra < 2) && ((op.Equals("s")) || (op.Equals("S"))))
						{
							Console.WriteLine("Deseas agregar concepto de maquinaria [S/N]");
							op = Console.ReadLine();
							if ((op.Equals("S")) || (op.Equals("s")))
							{
								posmaquinaria++;
								capturarconceptos(2, "Maquinaria", posmaquinaria);
							}
						}
						break;

					case 4:
						op = "s";
						while ((posmanodeobra < 2) && ((op.Equals("s")) || (op.Equals("S"))))
						{
							Console.WriteLine("Deseas agregar concepto de servicio [S/N]");
							op = Console.ReadLine();
							if ((op.Equals("S")) || (op.Equals("s")))
							{
								posservicios++;
								capturarconceptos(3, "Servicios", posservicios);
							}
						}
						break;

					case 5:
						subtotal = 0;
						subtotales(posmateriales, "Materiales", 0);
						subtotales(posmanodeobra, "Mano de obra", 1);
						subtotales(posmaquinaria, "Maquinaria", 2);
						subtotales(posservicios, "Servicios", 3);
						Console.WriteLine("El subtotal de la obra fue--->  " + subtotal);
						tiva = (subtotal * (proyecto.getIva()) / 100);
						Console.WriteLine("El IVA de la obra fue--->  " + tiva);
						subtotalobra = subtotal + tiva;
						Console.WriteLine("El subtotal de la obra con iva fue--->  " + subtotalobra);
						total = (subtotalobra * (proyecto.genInflacion() / 100)) + (subtotalobra * (proyecto.genMargenganancia() / 100)) + subtotalobra;
						Console.WriteLine("El total de la obra es --->  " + total);
						break;
				}
			}
			Console.ReadKey();
		}


	}

}
