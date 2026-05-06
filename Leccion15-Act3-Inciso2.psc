Algoritmo PrimosyPares
    Definir i, j Como Entero
    Definir esPrimo Como Logico
    Definir cont, suma Como Entero
    i <- 300
    cont <- 0
    suma <- 0
    Mientras i >= 1 Hacer
        Si i MOD 2 = 0 Entonces
            suma <- suma + i
        FinSi
        esPrimo <- Verdadero
        
        Si i <= 1 Entonces
            esPrimo <- Falso
        SiNo
            j <- 2
            Mientras j < i Y esPrimo Hacer
                Si i MOD j = 0 Entonces
                    esPrimo <- Falso
                FinSi
                j <- j + 1
            FinMientras
        FinSi
        Si esPrimo Entonces
            cont <- cont + 1
        FinSi
        
        i <- i - 1
    FinMientras
    
    Escribir "Cantidad de los numeros primos: ", cont
    Escribir "Suma de los numeros pares: ", suma
FinAlgoritmo