// Conversione basi.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;
int _tmain()
{
	char out[16] = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
	int numC[70];
	int numero, base, index = 0, next;

	Inizio:
	cout << "Inserisci il numero che vuoi convertire: ";
	cin >> numero;
	if (numero < 1){
		cout << "Non posso convertire il numero " << numero << endl;
		goto Inizio;
	}
	cout << "Inserisci la base a cui vuoi convertirlo(Max 16): ";
	cin >> base;
	if (base < 2||base >16){
		cout << "Non posso convertire in base " << base<<endl;
		goto Inizio;
	}
	
	while (numero >= 1){
		numC[index] = numero % base;
		index++;
		numero /= base;
	}
	

	cout << "\nNumero convertito: ";
	for (index--; index >= 0; index--){
		next = numC[index];
		cout << out[next];
	}

	cout << endl<<endl;
	system("pause");
	return 0;
}