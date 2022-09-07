using System;

class Cpersona
{
	public String nombre;
	public String actividad;

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
