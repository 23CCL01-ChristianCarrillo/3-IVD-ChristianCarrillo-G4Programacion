Algoritmo Parqueo
    Definir carros, disp Como Entero
    
    autos <- 0
    
    Repetir
        disp <- 200 - carros
        
        Escribir "Espacios disponibles: ", disp
        
        carros <- carros + 1
        
    Hasta Que carros = 200
    
    Escribir "Ya no hay espacios libres"
FinAlgoritmo