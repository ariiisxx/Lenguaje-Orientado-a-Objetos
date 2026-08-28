import java.util.Scanner;

public class FacturaTest 
{
    public static void main(String args[])
    {
        Factura ferre = new Factura();
        Scanner input = new Scanner(System.in);
        
        System.out.println("Ingresa el numero de pieza: ");
        ferre.numeroPieza = input.nextLine();
        
        System.out.println("Ingresa la descripcion: ");
        ferre.descripcion = input.nextLine();
        
        System.out.println("Ingresa la cantidad: ");
        ferre.cantidad = input.nextInt();
        
        System.out.println("Ingrese el precio: ");
        ferre.precioArticulo = input.nextDouble();
        
        if (ferre.precioArticulo < 0) ferre.precioArticulo = 0.0;
        if (ferre.cantidad < 0) ferre.cantidad = 0;
        
        System.out.println("Factura: " + ferre.obtenerMontoFactura());
        
    }
}