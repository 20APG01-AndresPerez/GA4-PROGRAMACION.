Algoritmo Act1_Inc1_Lecc11
	Definir cupolim, cupodis Como Entero
	
	Repetir
		Escribir "Ingrese al estacionamiento"
		Leer cupodis
	Hasta Que cupodis <=250
	
	Si cupodis>250 Entonces
		Escribir "Ya no hay espacio"
	SiNo
		Escribir "Cupo disponible"
	Fin Si
	Escribir "Eres el numero: ",cupodis
FinAlgoritmo
