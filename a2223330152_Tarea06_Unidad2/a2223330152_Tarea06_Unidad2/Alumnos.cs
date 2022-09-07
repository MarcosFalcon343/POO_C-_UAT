using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2223330152_Tarea06_Unidad2
{
    class Alumnos
    {
        private string nombre;
        private double calificacion;
        private char aula;
        public Alumnos(string _nombre, double _calificacion, char _aula)
        {
            if (_calificacion > 10)
            {
                calificacion = 10;
            }
            else if (_calificacion < 0)
            {
                calificacion = 0;
            }
            else
            {
                calificacion = _calificacion;
            }
            nombre = _nombre;
            aula = _aula;
        }
        public string getNombre()
        {
            return nombre;
        }
        public double getCalificacion()
        {
            return calificacion;
        }
        public char getAula()
        {
            return aula;
        }
    }
}