using System;
class FechaTest
{
    public static void Main(string[] args)
        {
            //FechaTest
            //Crear primer objeto
            Fecha fecha1 = new Fecha();
                
            Console.WriteLine("Ingresa el dia: ");
            fecha1.dia = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa el mes (numero): ");
            fecha1.mes = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Ingresa el año: ");
            fecha1.anio = int.Parse(Console.ReadLine());
                    
            fecha1.mostrarFecha();
    
         }
}
    