Algoritmo Act3_Inc2_Lecc9
	Definir num, i, contador como Enteros
	
	contador= 0
	i=1
	Escribir "Digite un numero entero: "
	Leer num
	
	Mientras i<= num Hacer
		
		Si num MOD i=0 Entonces
			contador=contador+1
		FinSi
		
		i=i+1
	Fin Mientras
	
	Si contador = 2 Entonces
		Escribir "El numero es primo"
	SiNo
		Escribir "El numero no es primo"
	FinSi
	
FinAlgoritmo
