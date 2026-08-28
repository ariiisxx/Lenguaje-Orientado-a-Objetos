using System;

class Factura
{
    public string numeroPieza;
    public string descripcion;
    public int cantidad;
    public double precioArticulo;

    public Factura()
    {
        numeroPieza = "";
        descripcion = "";
        cantidad = 0;
        precioArticulo = 0.0;
    }

    public double obtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }
}