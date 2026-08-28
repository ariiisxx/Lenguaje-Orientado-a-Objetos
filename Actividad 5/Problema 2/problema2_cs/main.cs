using System; 
class Empleado
{
    //Atributos
        public string primerNombre;
        public string apellidoPaterno;
        public double salarioMensual;

    //Constructor
    public Empleado()
    {
        primerNombre = "";
        apellidoPaterno = "";
        salarioMensual = 0.0;
    }
    
    //Metodos
    public void aumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    }
    
    public double salarioAnual()
    {
        return salarioMensual * 12;
    }
}