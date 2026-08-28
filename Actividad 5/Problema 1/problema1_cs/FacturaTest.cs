using System;

class FacturaTest
{
    public static void Main(string[] args)
    {
        Factura ferre = new Factura();

        Console.WriteLine("Ingresa el numero de pieza: ");
        ferre.numeroPieza = Console.ReadLine();

        Console.WriteLine("Ingresa la descripcion: ");
        ferre.descripcion = Console.ReadLine();

        Console.WriteLine("Ingresa la cantidad: ");
        ferre.cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el precio: ");
        ferre.precioArticulo = double.Parse(Console.ReadLine());

        if (ferre.precioArticulo < 0)
            ferre.precioArticulo = 0.0;

        if (ferre.cantidad < 0)
            ferre.cantidad = 0;

        Console.WriteLine("Factura: " + ferre.obtenerMontoFactura());
    }
}