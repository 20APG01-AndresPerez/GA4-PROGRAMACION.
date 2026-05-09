Algoritmo Act1_Inc1_Lecc15
	Definir opcion, contNi, contAdu, totni, totadu, totgen Como Entero
	
	contAdu=0
	contNi= 0
	totni=0
	totadu=0
	
	Repetir
		
		Escribir "1. Niño"
		Escribir "2. Adulto"
		Escribir "3. Salir"
		Leer opcion
		
		Si opcion = 1 Entonces
			
			contNi = contNi+ 1
			totni = totni + 10
			
		SiNo
			
			Si opcion = 2 Entonces
				
				contAdu = contAdu + 1
				totAdu = totAdu + 15
				
			FinSi
			
		FinSi
		
	Hasta Que opcion = 3
	
	totgen = totni + totadu
	
	Escribir "Cantidad de niños: ", contNi
	Escribir "Cantidad de adultos: ", contadu
	
	Escribir "Total niños: Q", totNi
	Escribir "Total adultos: Q", totadu
	
	Escribir "Total general: Q", totgen
FinAlgoritmo
