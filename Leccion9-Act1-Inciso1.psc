Algoritmo manzanas
    Definir pesofinal, manzana Como Real
    
    pesofinal <- 0
    
    Mientras pesofinal < 1000 Hacer
        Escribir "Coloca una manzana en la báscula(en gramos): "
        Leer manzana
        
        pesofinal <- pesofinal + manzana
        
        Escribir "Peso acumulado: ", pesofinal, "g"
    FinMientras
    
    Escribir "Ya tienes 1 kg de manzanas"
FinAlgoritmo