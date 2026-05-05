Algoritmo NumerosPrimos
    Definir num, i, cont Como Entero
    
    Escribir "Ingrese un número:"
    Leer num
    
    i <- 1
    cont <- 0
    
    Mientras i <= num Hacer
        Si num % i = 0 Entonces
            cont <- cont + 1
        FinSi
        
        i <- i + 1
    FinMientras
    
    Si cont = 2 Entonces
        Escribir "El número es primo"
    Sino
        Escribir "El número no es primo"
    FinSi
FinAlgoritmo