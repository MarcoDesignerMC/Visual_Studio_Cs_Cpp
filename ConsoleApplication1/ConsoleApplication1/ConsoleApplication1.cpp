// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
bool data_valida(int giorno, int mese, int anno);

using namespace std;
int _tmain()
{
	int giorno, mese, anno;
	char spazio;
	cout << "Inserisci una data: ";
	cin >> giorno;
	cin >> spazio;
	cin >> mese;
	cin >> spazio;
	cin >> anno;
	bool controllo = data_valida(giorno, mese, anno);
	if (controllo){
		cout << "La data è valida. ";
	}
	else{
		cout << "Non mi risulta che esista una data del genere. ";
	}
	cout << endl << endl;
	system("pause");
	return 0;
}

bool data_valida(int giorni, int mese, int anno){

	if (mese < 1 || mese>12) return false;
	else return true;

	switch (mese){
	case 1:												//GENNAIO
		if (giorni <= 31 && giorni > 0){
			return true; 
		}else{
		return false; 
		}
		break;
	case 2:												//FEBBRAIO
		if ((anno % 4) == 0){
			if (giorni <= 29 && giorni > 0){
				return true;
			}
			else{
				return false;
			}
		}
		else{
			if (giorni <= 28 && giorni > 0){
				return true;
			}
			else{
				return false;
			}
		}
		break;

	case 3:												//MARZO	
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 4:												//APRILE
		if (giorni <= 30 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 5:												//MAGGIO
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 6:												//GIUGNO
		if (giorni <= 30 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 7:												//LUGLIO
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 8:												//AGOSTO
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 9:												//SETTEMBRE
		if (giorni <= 30 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 10:											//OTTOBRE
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 11:											//NOVEMBRE
		if (giorni <= 30 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	case 12:											//DICEMBRE
		if (giorni <= 31 && giorni > 0){
			return true;
		}
		else{
			return false;
		}
		break;

	}
}
