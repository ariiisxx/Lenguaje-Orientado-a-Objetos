#include <iostream>
using namespace std;

class Empleado
{
    //Atributos
    public:
        string primerNombre;
        string apellidoPaterno;
        double salarioMensual;

    //Constructor
    Empleado()
    {
        primerNombre = "";
        apellidoPaterno = "";
        salarioMensual = 0.0;
    }
    
    //Metodos
    void aumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    };
    
    double salarioAnual()
    {
        return salarioMensual * 12;
    };
};


int main()
{
    //EmpleadoTest
    //Crear primer objeto
    Empleado empleado1;

    empleado1.primerNombre = "Mariana ";
    empleado1.apellidoPaterno = "Perez";
    empleado1.salarioMensual = 12500;
    
    if(empleado1.salarioMensual <= 0)
    {
        empleado1.salarioMensual = 0.0;
    }

    //Crear segundo objeto
    Empleado empleado2;
    
    empleado2.primerNombre = "Carlos ";
    empleado2.apellidoPaterno = "Espinosa";
    empleado2.salarioMensual = 18500; 
    
    if(empleado2.salarioMensual <= 0)
    {
        empleado2.salarioMensual = 0.0;
    }

    cout << "Salario anual de " << empleado1.primerNombre << empleado1.apellidoPaterno << ": $" << empleado1.salarioAnual() << endl;
    cout << "Salario anual de " << empleado2.primerNombre << empleado2.apellidoPaterno << ": $" << empleado2.salarioAnual() << endl;

    //Aumento 
    empleado1.aumentarSalario();
    empleado2.aumentarSalario();

    cout << "Salario anual con aumento, de " << empleado1.primerNombre << empleado1.apellidoPaterno << ": $" << empleado1.salarioAnual() << endl;
    cout << "Salario anual con aumento, de " << empleado2.primerNombre << empleado2.apellidoPaterno << ": $" << empleado2.salarioAnual() << endl;
 
    return 0;
}
