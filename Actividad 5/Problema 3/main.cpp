#include <iostream>
using namespace std;

class Fecha
{
    //Atributos
    public:
        int mes;
        int dia;
        int anio;

    //Constructor
    Fecha()
    {
        mes = 0;
        dia = 0;
        anio = 0;
    }
    
    //Metodos
    void mostrarFecha()
    {
        cout << mes << " / " << dia << " / " << anio << endl;
    }
};


int main()
{
    //FechaTest
    //Crear primer objeto
    Fecha fecha1;

    cout << "Ingresa el dia: ";
    cin >> fecha1.dia;

    cout << "Ingresa el mes (numero): ";
    cin >> fecha1.mes;

    cout << "Ingresa el año: ";
    cin >> fecha1.anio;
    
    fecha1.mostrarFecha();
    
    return 0;
}
