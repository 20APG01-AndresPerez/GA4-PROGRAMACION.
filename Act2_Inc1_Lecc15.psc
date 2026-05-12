Algoritmo Act2_Inc1_Lecc15
	Definir cont, suma, n, i, divisores Como Entero
		cont <- 0
		suma <- 0
		Para n <- 2 Hasta 100 Hacer
			divisores <- 0
			Para i <- 1 Hasta n Hacer
				Si n % i = 0 Entonces
					divisores = divisores + 1
				FinSi
			FinPara
			Si divisores = 2 Entonces
				cont <- cont + 1
				suma <- suma + n
			FinSi
		FinPara
		Escribir "Cantidad de primos: ", cont
		Escribir "Suma de los mismos: ", suma
FinAlgoritmo
