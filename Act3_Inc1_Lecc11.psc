Algoritmo Act3_Inc1_Lecc11
	Definir num1, num2, menor, mayor, i, suma como Entero
	
	Escribir "Digite el primer numero entero: "
	Leer num1
	
	Escribir "Digite el segundo numero entero: "
	Leer num2
	
	Si num1 < num2 Entonces
		menor = num1
		mayor= num2
	SiNo
		menor = num2
		mayor = num1
		
	FinSi
	
	i =menor
	suma=0
	
	Repetir
		
		suma = suma + i
		
		i = i + 1
		
	Hasta Que i > mayor
	
	Escribir "La suma de los numeros enteros es: ", suma
FinAlgoritmo
