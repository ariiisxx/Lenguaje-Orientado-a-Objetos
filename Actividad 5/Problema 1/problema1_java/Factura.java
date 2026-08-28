public class Factura 
{ 
    //Atributos
    String numeroPieza;
    String descripcion;
    int cantidad;
    double precioArticulo;
    
    //Constructor
    Factura() 
    {
        numeroPieza = "";
        descripcion = "";
        cantidad = 0;
        precioArticulo = 0.0;
    }
    
    //Metodo
    double obtenerMontoFactura() 
    {
        return cantidad * precioArticulo;
    }
}

    