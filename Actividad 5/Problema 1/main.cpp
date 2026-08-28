#include <iostream>
using namespace std;

class Factura
{
    //Atributos
    public:
        string numeroPieza;
        string descripcion;
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

    //Metodos
    double obtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }
};


int main()
{
    //FacturaTest

    //Crear objeto
    Factura ferre;

    cout << "Ingresa el numero de pieza: ";
    cin >> ferre.numeroPieza;

    cout << "Ingresa la descripcion: ";
    cin >> ferre.descripcion;

    cout << "Ingresa la cantidad: ";
    cin >> ferre.cantidad;

    cout << "Ingrese el precio: ";
    cin >> ferre.precioArticulo;

    //Validaciones
    if(ferre.precioArticulo < 0)
    {
        ferre.precioArticulo = 0.0;
    }

    if(ferre.cantidad < 0)
    {
        ferre.cantidad = 0;
    }

    //Mostrar monto de la factura
    cout << "Factura: $" << ferre.obtenerMontoFactura() << endl;

    

    return 0;
}
