Algoritmo Act3_Inc2_Lecc11
	Definir num, suma Como Entero
	
	suma= 0
	
	Repetir
		
	Escribir "Digite numeros: "
	Leer num
	
	Si num >=1 y num <=9 Entonces
		
		suma= suma+num
	SiNo
		Escribir "Numero fuera del rango"
	FinSi
	Hasta Que num<1 o num >9

	Escribir "La suma total es: ", suma
	
	
	
FinAlgoritmo
