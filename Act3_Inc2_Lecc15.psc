Algoritmo Act3_Inc2_Lecc15
    Definir i, j, div, cPrimos, sPares Como Entero
    cPrimos <- 0
    sPares <- 0
    
    Para i <- 300 Hasta 1 Con Paso -1 Hacer
        Si i % 2 = 0 Entonces
            sPares <- sPares + i
        FinSi
        
        div <- 0
        Para j <- 1 Hasta i Hacer
            Si i % j = 0 Entonces 
                div <- div + 1 
            FinSi
        FinPara
        
        Si div = 2 Entonces 
            cPrimos <- cPrimos + 1 
        FinSi
    FinPara
    
    Escribir "Cantidad de primos: ", cPrimos
    Escribir "Suma de los pares: ", sPares
FinAlgoritmo
