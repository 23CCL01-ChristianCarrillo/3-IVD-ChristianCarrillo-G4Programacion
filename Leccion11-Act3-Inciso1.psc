Algoritmo SumaDeNumeros
    Definir num1, num2, menor, mayor, suma Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer num1
    
    Escribir "Ingrese el segundo número:"
    Leer num2
    
    Si num1 < num2 Entonces
        menor <- num1
        mayor <- num2
    Sino
        menor <- num2
        mayor <- num1
    FinSi
    
    suma <- 0
    
    Repetir
        suma <- suma + menor
        menor <- menor + 1
    Hasta Que menor > mayor
    
    Escribir "La suma de los números entre ellos es: ", suma
FinAlgoritmo