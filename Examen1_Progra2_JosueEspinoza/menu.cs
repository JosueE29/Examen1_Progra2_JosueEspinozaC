using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Progra2_JosueEspinoza
{
    public class Menu
    {
        Empleados empleados = new Empleados();//Se cree una variable para contener la instancia del new empleados


        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú Principal ---");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Consultar Empleado por Cédula");
                Console.WriteLine("3. Modificar Empleado por Cédula");
                Console.WriteLine("4. Borrar Empleado por Cédula");
                Console.WriteLine("5. Inicializar Arreglos");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;
                    case 2:
                        empleados.ConsultarEmpleados();
                        break;
                    case 3:
                        ModificarEmpleado();

                        break;
                    case 4:
                        BorrarEmpleado();
                        break;
                    case 5:
                        empleados.InicializarArreglos();
                        break;
                    case 6:
                        MostrarReportes();
                        break;
                    case 7:
                        Console.WriteLine("Muchas gracias por usar, saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 7);

        }
        private void MostrarReportes()
        {
            int opcionReporte;
            do
            {
                Console.WriteLine("\n--- Reportes ---");//Menu secundario, de reportes
                Console.WriteLine("1. Lista de empleados ");
                Console.WriteLine("2. Calcular promedio de salarios");
                Console.WriteLine("3. Regresar al menú principal");
                Console.Write("Seleccione una opción: ");
                opcionReporte = int.Parse(Console.ReadLine());

                switch (opcionReporte)
                {
                    case 1:
                        empleados.ListaEmpleados();
                        break;
                    case 2:
                        empleados.CalculoPromedios();
                        break;
                    case 3:
                        Console.WriteLine("Regresando al menu principal");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcionReporte != 3);
        }
        private void AgregarEmpleado()
        {
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese el salario: ");
            float salario = float.Parse(Console.ReadLine());

            empleados.AgregarEmpleado(cedula, nombre, direccion, telefono, salario);//Debido a errores en llamar al metodo se decidio crear un void en base al metodo de la clase empleados
            //Que se encargue de guardar los datos de la misma manera pero con diferente metodo, esta se crea con el fin de agregar empleados.
        }

        private void ModificarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a modificar: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();
            Console.Write("Ingrese la nueva dirección: ");
            string nuevaDireccion = Console.ReadLine();
            Console.Write("Ingrese el nuevo teléfono: ");
            string nuevoTelefono = Console.ReadLine();
            Console.Write("Ingrese el nuevo salario: ");
            float nuevoSalario = float.Parse(Console.ReadLine());

            empleados.ModificarEmpleados(cedula, nuevoNombre, nuevaDireccion, nuevoTelefono, nuevoSalario);//Debido a errores en llamar al metodo se decidio crear un void en base al metodo de la clase empleados
            //Que se encargue de guardar los datos de la misma manera pero con diferente metodo, esta se crea con el fin de Modificar empleados.
        }

        private void BorrarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a borrar: ");
            string cedula = Console.ReadLine();
            empleados.BorrarEmpleado(cedula);//Debido a errores en llamar al metodo se decidio crear un void en base al metodo de la clase empleados
            //Que se encargue de guardar los datos de la misma manera pero con diferente metodo, esta se crea con el fin de eliminar empleados.
        }

    }

}