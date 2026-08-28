using System;

class Fecha
{
    //Atributos
    public int mes;
    public int dia;
    public int anio;

    //Constructor
    public Fecha()
    {
        mes = 0;
        dia = 0;
        anio = 0;
    }
    
    //Metodos
    public void mostrarFecha()
    {
        Console.WriteLine(mes + "/" + dia + "/" + anio);
    }
}