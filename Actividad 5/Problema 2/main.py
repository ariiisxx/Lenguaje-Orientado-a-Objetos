class Empleado:
    #Atributos
    def __init__(self):
        self.primerNombre = ""
        self.apellidoPaterno = ""
        self.salarioMensual = 0.0
        
    #Metodo
    def aumentarSalario(self):
        self.salarioMensual = self.salarioMensual * 1.10
    def salarioAnual(self):
        return self.salarioMensual * 12

#Objetos
#FacturaTest
empleado1 = Empleado()

empleado1.primerNombre = "Mariana "
empleado1.apellidoPaterno = "Perez"
empleado1.salarioMensual = 12500
if(empleado1.salarioMensual <= 0):
    empleado1.salarioMensual = 0.0

empleado2 = Empleado()

empleado2.primerNombre = "Carlos "
empleado2.apellidoPaterno = "Espinosa"
empleado2.salarioMensual = 18500
if(empleado2.salarioMensual <= 0):
    empleado2.salarioMensual = 0.0


print("Salario anual de ", empleado1.primerNombre, empleado1.apellidoPaterno, ": $", empleado1.salarioAnual())
print("Salario anual de ", empleado2.primerNombre, empleado2.apellidoPaterno, ": $", empleado2.salarioAnual())

#Aumento 
empleado1.aumentarSalario()
empleado2.aumentarSalario()

print("Salario anual con aumento, de ", empleado1.primerNombre, empleado1.apellidoPaterno, ": $", empleado1.salarioAnual())
print("Salario anual con aumento, de ", empleado2.primerNombre, empleado2.apellidoPaterno, ": $", empleado2.salarioAnual())

