Algoritmo Act2_Inc1_Lecc9
	Definir totmone, monedas Como Entero
	totmone=0
	monedas=0
	
	Mientras totmone<350 Hacer
		Escribir "Ingrese la cantidad de monedas que tiene: "
		Leer monedas
		
		totmone = totmone + monedas
		Si totmone>=350 Entonces
			Escribir "Lograste avanzar al nivel 5"
		SiNo
			Escribir "Tienes las monedas insuficientes"
		FinSi
		
	Fin Mientras
	
FinAlgoritmo
