Algoritmo Factoriales
    Definir num, i, fact Como Entero
    Escribir "Ingrese un número:"
    Leer num
    i <- num
    fact <- 1
    Repetir
        fact <- fact * i
        i <- i - 1
    Hasta Que i = 0
    Escribir "El factorial es: ", fact
FinAlgoritmo