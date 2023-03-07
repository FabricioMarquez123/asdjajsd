using Parcial1.Entidades;
using Parcial1.Negocio;
using System;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            ClsUsuario clsUsuario = new ClsUsuario();

            Venta venta = new Venta();
            ClsVenta clsVenta = new ClsVenta();

            Console.WriteLine("Digite su usuario");
            usuario.Usuarioo = Console.ReadLine();
            Console.WriteLine("Digite su contraseña");
            usuario.Contrasenia = Console.ReadLine();
            if(clsUsuario.Login(usuario) == true) {
                Console.WriteLine("Digite id del producto");
                venta.IdProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el nombre del producto");
                venta.Nombre = Console.ReadLine();
                Console.WriteLine("Digite la descripcion del producto");
                venta.Descripcion = Console.ReadLine();
                Console.WriteLine("Digite el precio del producto");
                venta.Precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de productos que lleva");
                venta.Cantidad = int.Parse(Console.ReadLine());
                clsVenta.Cargo(venta);
            }


        }
    }
}
