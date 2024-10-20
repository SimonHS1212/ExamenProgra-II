using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empleado
{
    public int cedula;
    public string nombre;
    public string direccion;
    public string telefono;
    public int salario;

    public Empleado(int cedula, string nombre, string direccion, string telefono, int salario)
    {
        this.cedula = cedula;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.salario = salario;
    }
}
