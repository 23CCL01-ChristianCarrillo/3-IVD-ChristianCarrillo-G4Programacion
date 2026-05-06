Algoritmo RuedaDeLaFortuna
    Definir opcion Como Entero
    Definir boletos, total Como Entero
    boletos <- 0
    total <- 0
    opcion <- -1
    Mientras opcion <> 0 Hacer
        Escribir "Ingrese tipo de entrada (1=niño, 2=adulto, 0=salir): "
        Leer opcion
        Si opcion = 1 Entonces
            total <- total + 10
            boletos <- boletos + 1
        Sino
            Si opcion = 2 Entonces
                total <- total + 15
                boletos <- boletos + 1
            FinSi
        FinSi
    FinMientras
    Escribir "Boletos vendidos: ", boletos
    Escribir "Total recaudado: $", total
FinAlgoritmo