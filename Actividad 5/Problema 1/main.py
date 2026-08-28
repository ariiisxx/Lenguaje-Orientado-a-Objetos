class Factura:
    #Atributos
    def __init__(self):
        self.numeroPieza = ""
        self.descripcion = ""
        self.cantidad = 0 
        self.precioArticulo = 0.0
        
    #Metodo
    def obtenerMontoFactura(self):
        return self.cantidad * self.precioArticulo

#Objeto
ferre = Factura()

#FacturaTest
ferre.numeroPieza = input("Ingresa el numero de pieza: ")
ferre.descripcion = input("Ingrese la descripción: ")
ferre.cantidad = int(input("Ingrese la cantidad: "))
ferre.precioArticulo = float(input("Ingrese el precio del articulo: "))

ferre.cantidad = 0 if ferre.cantidad < 0 else ferre.cantidad
ferre.precioArticulo = 0.0 if ferre.precioArticulo < 0 else ferre.precioArticulo

print("Factura:", ferre.obtenerMontoFactura())