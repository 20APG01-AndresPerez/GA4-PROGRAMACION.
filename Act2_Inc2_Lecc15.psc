Algoritmo Act2_Inc2_Lecc15
		Definir billete, cantidad100, sumaTotal, i Como Entero
		cantidad100 = 0
		sumaTotal = 0
		Para i <- 1 Hasta 1000 Hacer
			Escribir "Ingrese denominación del billete ", i, " (20, 50, 100):"
			Leer billete
			sumaTotal <- sumaTotal + billete
			Si billete = 100 Entonces
				cantidad100 = cantidad100 + 1
			FinSi
		FinPara
		Escribir "Billetes de $100: ", cantidad100
		Escribir "Dinero total: $", sumaTotal
FinAlgoritmo
