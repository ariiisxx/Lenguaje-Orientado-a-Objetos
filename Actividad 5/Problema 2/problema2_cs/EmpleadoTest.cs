using System;

class EmpleadoTest
{
        public static void Main(string[] args)
        {
            //EmpleadoTest
            //Crear primer objeto
            Empleado empleado1 = new Empleado();
        
            empleado1.primerNombre = "Mariana ";
            empleado1.apellidoPaterno = "Perez";
            empleado1.salarioMensual = 12500;
            
            if(empleado1.salarioMensual <= 0)
                empleado1.salarioMensual = 0.0;
            
        
            //Crear segundo objeto
            Empleado empleado2 = new Empleado();
            
            empleado2.primerNombre = "Carlos ";
            empleado2.apellidoPaterno = "Espinosa";
            empleado2.salarioMensual = 18500; 
            
            if(empleado2.salarioMensual <= 0)
                empleado2.salarioMensual = 0.0;
            
        
            Console.WriteLine("Salario anual de " + empleado1.primerNombre + empleado1.apellidoPaterno + ": $" + empleado1.salarioAnual());
            Console.WriteLine("Salario anual de " + empleado2.primerNombre + empleado2.apellidoPaterno + ": $" + empleado2.salarioAnual()); 
        
            //Aumento 
            empleado1.aumentarSalario();
            empleado2.aumentarSalario();
        
            Console.WriteLine("Salario anual con aumento, de " + empleado1.primerNombre + empleado1.apellidoPaterno + ": $" + empleado1.salarioAnual());
            Console.WriteLine("Salario anual con aumento, de " + empleado2.primerNombre + empleado2.apellidoPaterno + ": $" + empleado2.salarioAnual());
        }
}