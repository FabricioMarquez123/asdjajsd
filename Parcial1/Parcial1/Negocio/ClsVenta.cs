using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Negocio
{
    public class ClsVenta
    {
        public void Cargo(Venta venta)
        {
            var Total = venta.Precio * venta.Cantidad;
            var Descuento = 0;
            if(Total > 50)
            {
                Descuento = 10;
                Total = Total - Descuento;
            }
            
            

            Console.WriteLine($"\nID: {venta.IdProducto}");
            Console.WriteLine($"Nombre: {venta.Nombre}");
            Console.WriteLine($"Descripcion: {venta.Descripcion}");
            Console.WriteLine($"Precio: {venta.Precio}");
            Console.WriteLine($"Cantidad: {venta.Cantidad}");
            Console.WriteLine($"Descuento: {Descuento}");
            Console.WriteLine($"Total a pagar: {Total}");

        }
    }
}
