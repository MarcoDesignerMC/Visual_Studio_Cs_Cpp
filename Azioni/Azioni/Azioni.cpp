// Azioni.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;

int _tmain()
{
	int nAzioni,giorni;
	double pUIniz, pIniz, pUFin, pFin,gGiorn,gTot;

	cout << "Numero azioni: ";
	cin >> nAzioni;
	cout << "Prezzo unitario iniziale: ";
	cin >> pUIniz;
	cout << "Prezzo unitario finale: ";
	cin >> pUFin;
	cout << "Giorni: ";
	cin >> giorni;

	pIniz = nAzioni*pUIniz;
	pFin = nAzioni*pUFin;

	gTot= round((pIniz - pFin)*100)/100.0;
	gGiorn = round((gTot / giorni)*100)/100.0;

	if (gTot <= 0){
		cout << "Guadagno totale: " << gTot * -1 << " euro\n";
		
	}
	else{
		cout << "Perdita totale: " << gTot << " euro\n";
		
	}
	if (gGiorn <= 0){
		cout << "Guadagno giornaliero: " << gGiorn * -1 << " euro\n\n";
		
	}
	else{
		cout << "Perdita giornaliera: " << gGiorn << " euro\n\n";
	}

	system("pause");
	return 0;
}

