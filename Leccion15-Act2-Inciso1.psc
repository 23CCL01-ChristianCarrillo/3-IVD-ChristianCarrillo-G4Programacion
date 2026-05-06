Algoritmo PrimosDel1Al100
    Definir i, u, cont, sum Como Entero
    Definir esPrimo Como Logico
    
    cont <- 0
    sum <- 0
    
    Para i <- 1 Hasta 100 Hacer
        esPrimo <- Verdadero
        
        Si i <= 1 Entonces
            esPrimo <- Falso
        SiNo
            u <- 2
            Mientras u < i Y esPrimo Hacer
                Si i MOD u = 0 Entonces
                    esPrimo <- Falso
                FinSi
                u <- u + 1
            FinMientras
        FinSi
        
        Si esPrimo Entonces
            cont <- cont + 1
            sum <- sum + i
        FinSi
    FinPara
    
    Escribir "Cantidad de numeros primos: ", cont
    Escribir "Suma de los numeros primos: ", sum
FinAlgoritmo