public class Fecha
{
	//Atributos
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
        System.out.println(mes + " / " + dia + " / " + anio);
	}
}
