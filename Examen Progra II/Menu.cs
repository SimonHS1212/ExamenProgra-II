using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Menu
{
    List<Empleado> empleados = new List<Empleado>();

    public void MostrarMenu()
    {
        int opcion = 0;
        while (opcion != 7)
        {
            Console.WriteLine("\n--- Menu Principal ---");
            Console.WriteLine("1. Inicializar Arreglos");
            Console.WriteLine("2. Agregar Empleado");
            Console.WriteLine("3. Consultar Empleado");
            Console.WriteLine("4. Modificar Empleado");
            Console.WriteLine("5. Borrar Empleado");
            Console.WriteLine("6. Reportes");
            Console.WriteLine("7. Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    InicializarArreglos();
                    break;
                case 2:
                    AgregarEmpleado();
                    break;
                case 3:
                    ConsultarEmpleado();
                    break;
                case 4:
                    ModificarEmpleado();
                    break;
                case 5:
                    BorrarEmpleado();
                    break;
                case 6:
                    MostrarReportes();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }

    void AgregarEmpleado()
    {
        Console.Write("Cedula: ");
        int cedula = int.Parse(Console.ReadLine());
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Direccion: ");
        string direccion = Console.ReadLine();
        Console.Write("Telefono: ");
        string telefono = Console.ReadLine();
        Console.Write("Salario: ");
        int salario = int.Parse(Console.ReadLine());

        empleados.Add(new Empleado(cedula, nombre, direccion, telefono, salario));
        Console.WriteLine("Empleado agregado.");
    }

    void ConsultarEmpleado()
    {
        Console.Write("Ingrese cedula: ");
        int cedula = int.Parse(Console.ReadLine());

        foreach (Empleado empleado in empleados)
        {
            if (empleado.cedula == cedula)
            {
                Console.WriteLine($"Nombre: {empleado.nombre}\nDirreccion: {empleado.direccion} \nTelefono: {empleado.telefono} \nSalario: {empleado.salario}");
                return;
            }
        }
        Console.WriteLine("Empleado no encontrado.");
    }

    void ModificarEmpleado()
    {
        Console.WriteLine("Ingrese cedula del empleado a modificar: ");
        int cedula = int.Parse(Console.ReadLine());

        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine("Nuevo Nombre: ");
            empleado.nombre = Console.ReadLine();
            Console.WriteLine("Nueva direccion: ");
            empleado.direccion = Console.ReadLine();
            Console.WriteLine("Nuevo telefono: ");
            empleado.telefono = Console.ReadLine();
            Console.WriteLine("Nuevo salario: ");
            empleado.salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Empleado modificado existosamente.");
            return;
        }
        Console.WriteLine("Empleado no encontrado.");
    }

    void BorrarEmpleado()
    {
        Console.WriteLine("Ingrese cedula del empleado a borrar:");
        int cedula = int.Parse(Console.ReadLine());

        empleados.RemoveAll(e => e.cedula == cedula);
        Console.WriteLine("Empleado eliminado.");
    }

    void InicializarArreglos()
    {
        empleados = new List<Empleado>();
        Console.WriteLine("Arreglos inicializados.");
    }

    void MostrarReportes()
    {
        int opcion = 0;
        while (opcion != 5)
        {
            Console.WriteLine("\n--- Menu de reportes ---");
            Console.WriteLine("1. Consultar empleados por cedula");
            Console.WriteLine("2. Listar empleados ordenados por nombre");
            Console.WriteLine("3. Calcular y mostrar promedio de salarios");
            Console.WriteLine("4. Salario mas alto y mas bajo");
            Console.WriteLine("5. Regresar al menu principal");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConsultarEmpleado();
                    break;
                case 2:
                    ListarEmpleadosPorNombre();
                    break;
                case 3:
                    CalcularPromedioSalarios();
                    break;
                case 4:
                    MostrarSalarioAltoyBajo();
                    break;
                case 5:
                    Console.WriteLine("Regresando al menu principal...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }

    void ListarEmpleadosPorNombre()
    {
        empleados.Sort((e1, e2) => e1.nombre.CompareTo(e2.nombre));
        Console.WriteLine("\n--- Lista de Empleados Ordenados por Nombre ---");
        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine($"Nombre: {empleado.nombre}, Cedula: {empleado.cedula}");
        }
    }

    void CalcularPromedioSalarios()
    {
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            return;
        }
        double TotalSalarios = 0;
        foreach (Empleado empleado in empleados)
        {
            TotalSalarios += empleado.salario;
        }

        double promedio = TotalSalarios / empleados.Count;
        Console.WriteLine($"El promedio de los salarios es : {promedio}");
    }

    void MostrarSalarioAltoyBajo()
    {
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            return;
        }
        int salarioAlto = int.MinValue;
        int salarioBajo = int.MaxValue;

        foreach (Empleado empleado in empleados)
        {
            if (empleado.salario > salarioAlto)
            {
                salarioAlto = empleado.salario;
            }
            if (empleado.salario < salarioBajo)
            {
                salarioBajo = empleado.salario;
            }
        }
        Console.WriteLine($"El salario mas alto es: {salarioAlto}");
        Console.WriteLine($"El salario mas bajo es: {salarioBajo}");
    }
}








