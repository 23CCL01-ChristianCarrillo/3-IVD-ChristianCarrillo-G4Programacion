Algoritmo Cajero
    Definir i, dinero, cont, suma Como Entero
    cont <- 0
    suma <- 0
    
    Para i <- 1 Hasta 1000 Hacer
        Segun Aleatorio(1,3) Hacer
            1:
                dinero <- 20
            2:
                dinero <- 50
            3:
                dinero <- 100
        FinSegun
        
        Si dinero = 100 Entonces
            cont <- cont + 1
            suma <- suma + 100
        FinSi
    FinPara
    
    Escribir "Cantidad de billetes de 100: ", cont
    Escribir "Total de dinero con billetes de $100: $", suma
FinAlgoritmo