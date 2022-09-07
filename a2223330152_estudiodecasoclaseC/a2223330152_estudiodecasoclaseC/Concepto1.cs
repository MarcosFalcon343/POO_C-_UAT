using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_estudiodecasoclaseC
{
    class Concepto1
    {
		public String concepto;
		public String unidadmedida;
		public String precio;
		public String cantidad;

		public Concepto1(String concepto, String unidadmedida, double precio, double cantidad)
		{

			this.concepto = concepto;
			this.unidadmedida = unidadmedida;
			this.precio = Convert.ToString(precio);
			this.cantidad = Convert.ToString(cantidad);
		}

		public double getTotalconcepto()
		{
			return Convert.ToDouble(this.cantidad) * Convert.ToDouble(this.precio);
		}

		public String getMostrartotalconcepto()
		{
			String cadena = "El total del concepto " + this.concepto + " fue " + Convert.ToString(getTotalconcepto());
			return cadena;
		}
	}
}
