public class Empleado 
{
    //Atributos
        String primerNombre;
        String apellidoPaterno;
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

