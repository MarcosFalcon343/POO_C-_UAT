﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_tareas_unidad2
{
    class Cmateria
    {
		private String materia;
		Calumno[] alumno;

		public Cmateria(String materia, int numAlumnos)
		{
			this.materia = materia;
			this.alumno = new Calumno[numAlumnos];
		}

		public String getMateria()
		{
			return this.materia;
		}

		public void setAlumno(String nombre, String matricula, int calf, int numAlumno)
		{
			this.alumno[numAlumno] = new Calumno(nombre, matricula, calf);
		}

		public String datoAlumno(int numalumno)
		{
			return alumno[numalumno].ToString();
		}

		public int promedio(int numAlumnos)
		{
			int suma = 0;
			for (int i = 0; i < numAlumnos; i++)
			{
				suma = suma + alumno[i].getCalificacion();
			}
			return (suma / numAlumnos);

		}
	}
}
