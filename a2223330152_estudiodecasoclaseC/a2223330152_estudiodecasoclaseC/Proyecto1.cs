using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_estudiodecasoclaseC
{
    class Proyecto1
    {
		public String iva;
		public String inflacion;
		public String margenganencia;

		public double getIva()
		{
			return Convert.ToDouble(this.iva);
		}

		public double genInflacion()
		{
			return Convert.ToDouble(inflacion);
		}

		public double genMargenganancia()
		{
			return Convert.ToDouble(margenganencia);
		}

		public Proyecto1(double iva, double inflacion, double margenganancia)
		{

			this.iva = Convert.ToString(iva);
			this.inflacion = Convert.ToString(inflacion);
			this.margenganencia = Convert.ToString(margenganancia);
		}
	}
}
