using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_tareas_unidad2
{
    class Calumno
    {
		private String matricula;
		private String nombre;
		private int calif;

		public Calumno(String nombre, String matricula, int calficacion)
		{
			this.nombre = nombre;
			this.matricula = matricula;
			this.calif = calficacion;
		}

		public int getCalificacion()
		{
			return this.calif;
		}

        public override string ToString()
        {
            return "Alumno [matricula=" + matricula + ", nombre=" + nombre + ", calif=" + calif + "]";
		}
    }
}
