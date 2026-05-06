Algoritmo MultiplosDe20
    Definir i, mult, suma, cont Como Entero
    suma <- 0
    cont <- 0
    Para i <- 1 Hasta 20 Hacer
        mult <- i * 7
        
        suma <- suma + mult
        
        Si mult MOD 2 = 0 Entonces
            cont <- cont + 1
        FinSi
    FinPara
    Escribir "La sumatoria de los primeros 20 multiplos de 7: ", suma
    Escribir "La cantidad de multiplos pares es: ", cont
FinAlgoritmo