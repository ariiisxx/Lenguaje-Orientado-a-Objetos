class Fecha:
    #Atributos
    def __init__(self):
        self.mes = 0
        self.dia = 0
        self.anio = 0 
        
    #Metodo
    def mostrarFecha(self):
        print(self.mes, " / ", self.dia, " / ", self.anio)

#Objeto
fecha1 = Fecha()

#FacturaTest
fecha1.mes = int(input("Ingresa el dia: "))
fecha1.dia = int(input("Ingresa el mes: "))
fecha1.anio = int(input("Ingresa el año: "))

fecha1.mostrarFecha()