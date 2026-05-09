Algoritmo Act2_Inc1_Lecc11
	Definir num, i, factorial Como Entero
	i=1
	factorial=1
	
	Escribir "Digite un numero entero:  "
	Leer num
	
	Repetir
		
		factorial = factorial * i
		i = i + 1
		
	Hasta Que i > num
	
	Escribir "El factorial es: ", factorial
FinAlgoritmo
