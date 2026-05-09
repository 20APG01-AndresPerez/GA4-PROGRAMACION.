Algoritmo Act3_Inc1_Lecc10
	
	Definir num, i, contador, suma Como Entero
	
	suma = 0
	
	Para num <- 1 Hasta 22 Hacer
		
		contador = 0
		
		Para i <- 1 Hasta num Hacer
			
			Si num MOD i = 0 Entonces
				contador = contador + 1
			FinSi
			
		Fin Para
		
		Si contador = 2 Entonces
			suma = suma + num
		FinSi
		
	Fin Para
	
	Escribir "La suma de los numeros primos entre 1 y 22 es: ", suma
	
FinAlgoritmo
