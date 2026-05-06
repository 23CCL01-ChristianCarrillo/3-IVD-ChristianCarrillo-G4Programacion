Algoritmo NumerosPrimos
    Definir i, j, cont, suma Como Entero
    suma <- 0
    Para i <- 2 Hasta 22 Hacer
        cont <- 0
        
        Para j <- 1 Hasta i Hacer
            Si i % j = 0 Entonces
                cont <- cont + 1
            FinSi
        FinPara
        
        Si cont = 2 Entonces
            suma <- suma + i
        FinSi
    FinPara
    Escribir "La suma de los números primos entre 1 y 22 es: ", suma
FinAlgoritmo