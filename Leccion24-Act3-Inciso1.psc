Algoritmo SumaDePrimos
    Definir i, j Como Entero
    Definir esPrimo Como Logico
    Definir suma Como Entero
    suma <- 0
    Para i <- 2 Hasta 50 Hacer
        esPrimo <- Verdadero
        j <- 2
        Mientras j * j <= i Y esPrimo Hacer
            Si i MOD j = 0 Entonces
                esPrimo <- Falso
            FinSi
            j <- j + 1
        FinMientras
        Si esPrimo Entonces
            suma <- suma + i
        FinSi
    FinPara
    Escribir "Suma de los numeros primos: ", suma
FinAlgoritmo