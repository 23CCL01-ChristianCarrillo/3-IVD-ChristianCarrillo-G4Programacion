Algoritmo Atraccion
    Definir tipo, totalboletos, totaldinero Como Entero
    totalboletos <- 0
    totaldinero <- 0
    Repetir
        Escribir "Ingrese tipo de boleto (1=Adulto $15, 2=Niño $10, 0=Salir):"
        Leer tipo
        Si tipo = 1 Entonces
            totalboletos <- totalboletos + 1
            totaldinero <- totaldinero + 15
        FinSi
        Si tipo = 2 Entonces
            totalboletos <- totalboletos + 1
            totaldinero <- totaldinero + 10
        FinSi
    Hasta Que tipo = 0
    Escribir "Total boletos vendidos: ", totalboletos
    Escribir "Total dinero recaudado: $", totaldinero
FinAlgoritmo