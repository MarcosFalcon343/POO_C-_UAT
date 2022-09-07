using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad01_Tarea02
{
    class Cpersona
    {
		String nombre;
		String actividad;

		public Cpersona(String nombre, String actividad)
		{
			this.nombre = nombre;
			this.actividad = actividad;
		}

		public String getNombre()
		{
			return this.nombre;
		}
		public String toString()
		{
			return this.getNombre() + " " + this.actividad;
		}
	}
}
