using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Progra2_JosueEspinoza
{
    public class Empleados
    {
        //Se crean los arrays de un tamaño de diez segun lo indicado por el profesor
        public string[] cedulas = new string[2];
        public string[] nombres = new string[2];
        public string[] direcciones = new string[2];
        public string[] telefonos = new string[2];
        public double[] salarios = new double[2];
        public int contador = 0;


        //Creamos un metodo agregarEmpleados el cual tendra los parametros necesarios para funcionar
        public void AgregarEmpleado(string cedula, string nombre, string direccion, string telefono, float salario)
        {
            if (contador < 2)//Mediante un contador mantenemos las veces que se van a cargar los arrays.
            {
                cedulas[contador] = cedula;
                nombres[contador] = nombre;
                direcciones[contador] = direccion;
                telefonos[contador] = telefono;
                salarios[contador] = salario;

                contador++;//Esto se repetira hasta llegar a 10.
                Console.WriteLine("El empleado se ha agregado de manera exitosa!!!!!");

            }
            else
            {
                Console.WriteLine("Espacio lleno, no se pueden agregar mas empleados");//En casom de llegar a 10 nos dara este mensaje
            }
        }
        public void ConsultarEmpleados()//Creamos un void con el fin  de consultar los empleados en el array segun la cedula buscada
        {
            Console.Write("Ingrese la cédula del empleado que desea consultar: ");
            string cedulaBuscada = Console.ReadLine();
            int indice = Array.IndexOf(cedulas, cedulaBuscada);//MNediante un Array.IndexOf se hace la busqyeda del parametro cedulas para encontrar al empleado

            if (indice != -1)
            {
                Console.WriteLine($"Cédula: {cedulas[indice]}, Nombre: {nombres[indice]}, Dirección: {direcciones[indice]}, Teléfono: {telefonos[indice]}, Salario: {salarios[indice]}");//Imprimimos la informacion del empleado
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");//Si el empleado no se encuentra veremos este mensaje
            }
        }
        public void ModificarEmpleados(string cedula, string nuevoNombre, string nuevaDireccion, string nuevoTelefono, float nuevoSalario)
        {
            int indice = Array.IndexOf(cedulas, cedula);//Mediante un IndexOf Buscamos especificamente el empleado mediante la cedula.

            if (indice == -1)
            {
                Console.WriteLine("El empleado no se ha encontrado");//Si el empleado no se encuentra veremos este mensaje
                return;
            }
            //Se vuelven a solicitar datos con el fin de modificar los datos ingresados
            nombres[indice] = nuevoNombre;
            direcciones[indice] = nuevaDireccion;
            telefonos[indice] = nuevoTelefono;
            salarios[indice] = nuevoSalario;
            Console.WriteLine("El empleado hab sido actualizado de manera exitosa");
        }
        public void BorrarEmpleado(string cedula)//Creamos un void con el objetivo de borrar los datos de los empleados segun la cedula
        {
            int indice = Array.IndexOf(cedulas, cedula);
            if (indice != -1)
            {
                cedulas[indice] = null;//Los datos pasan a ser datos null o bien podrian ser emptys
                nombres[indice] = null;
                direcciones[indice] = null;
                telefonos[indice] = null;
                salarios[indice] = 0;
                Console.WriteLine("El empleado ha sido borrado exitosamente.");
            }
            else
            {
                Console.WriteLine("El empleado no se ha encontrado.");
            }
        }
        public void InicializarArreglos()//Inicializamos los datos con un metodo
        {
            for (int i = 0; i < cedulas.Length; i++)
            {
                cedulas[i] = null; 
                nombres[i] = null;
                direcciones[i] = null;
                telefonos[i] = null;
                salarios[i] = 0; 
            }
            contador = 0; // El contador se reinicia dejando que se introduzca nuevamente los 10 empleados
            Console.WriteLine("Los arreglos han sido inicializados correctamente.");
        }
        public void ListaEmpleados()
        {
            // Asegúrate de que la longitud sea la misma para todos los arreglos.
            for (int i = 0; i < nombres.Length; i++)
            {
                // Verificamos que el nombre no esté vacío.
                if (!string.IsNullOrEmpty(nombres[i]))
                {
                    // Muestra todos los datos del empleado
                    Console.WriteLine($"Nombre: {nombres[i]}, Cédula: {cedulas[i]}, Dirección: {direcciones[i]}, Teléfono: {telefonos[i]}, Salario: {salarios[i]}");
                }
            }
        }
        public void CalculoPromedios()//Creamos un metodo para el calculo de promedios
        {
            double suma = 0;
            int contadorEmpleados = 0;
            for (int i = 0; i < salarios.Length; i++)
            {
                if (salarios[i] > 0)//Va a suceder siempre que el array de salarios sea mayor a 0
                {
                    suma += salarios[i]; //por cada contador se suma uno+
                    contadorEmpleados++;//cada contador va aumentando
                }
            }
            if (contadorEmpleados > 0)
            {
                Console.WriteLine($"El promedio de los salarios es: {suma / contadorEmpleados}");//Terminamos imprimiendo el promedio total dividiendo la suma con el contador
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");//En caso de no tener empleados nos aparecera este mensaje
            }
        }

    }

}

        
    
