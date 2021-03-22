using System;
namespace CONTACTO
{
    public class contacto
    {
        //Crear una clase Contacto.Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
        //También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar 
        //el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido 
        //de sus datos. Crear también una clase llamada ProbarContacto. Esta clase deberá contener sólo la función Main, 
        //que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá que saluden.

        private string nombre;
        private string apellido;
        private string direccion;
        private int celular;
        public contacto()
        {
            Console.Write("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Digite su dirección: ");
            direccion = Console.ReadLine();
            Console.Write("Digite su celular: ");
            string num = Console.ReadLine();
            celular = int.Parse(num);
        }
        public void imprimir()
        {
            Console.Clear();
            Console.WriteLine("Su nombre es: {0} {1}", nombre, apellido);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Telefono: " + celular);
        }
    }
    public class ProbarContacto
    {
        static void Main(string[] args)
        {
            contacto cont = new contacto();
            cont.imprimir();
            Console.ReadKey();
        }
    }
}

