import java.util.Scanner;
public class FechaTest
{
        public static void main(String args[])
        {
            //FechaTest
            //Crear primer objeto
            Fecha fecha1 = new Fecha();
            Scanner input = new Scanner(System.in);

        
            System.out.println("Ingresa el dia: ");
            fecha1.dia = input.nextInt();

            System.out.println("Ingresa el mes (numero): ");
            fecha1.mes = input.nextInt();
        
            System.out.println("Ingresa el año: ");
            fecha1.anio = input.nextInt();
            
            fecha1.mostrarFecha();
        }
}
    