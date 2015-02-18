// SonoIndecisoSeComprareUniPad.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;
int _tmain()
{
	char a1;
	Ricco:
	cout << "Sei ricco? ";
	cin >> a1;

	if (a1 == 'N' || a1 == 'n'){
		char a2;
		cout << "Hai un mac? ";
		cin >> a2;

		if (a2 == 'N' || a2 == 'n'){
			char a3;
			cout << "Hai un iPhone? ";
			cin >> a3;
			if (a3 == 'N' || a3 == 'n'){
				char a4;
				cout << "Ti piace toccare le cose? ";
				cin >> a4;
				if (a4 == 'N' || a4 == 'n'){
					cout << "Non comprare l'iPad.\n\n";
					system("pause");
					return 0;
				}
				else if (a4 == 'S' || a4 == 's'){
					char a5;
					cout << "In modo inappropriato? ";
					cin >> a5;
					if (a5 == 'N' || a5 == 'n'){
						char a6;
						cout << "Ti piace fare scelte di testa tua? ";
						cin >> a6;
						if (a6 == 'N' || a6 == 'n'){
							char a7;
							cout << "Vuoi che Steve Jobs decida per te? ";
							cin >> a7;
							if (a7 == 'N' || a7 == 'n'){
								char a8;
								cout << "Ti piacerebbe che io decidessi per te? ";
								cin >> a8;
								if (a8 == 'N' || a8 == 'n'){
									char a9;
									Scelte:
									cout << "Allora perche usi questo diagramma di flusso? ";
									
									cout << "Hai un portatile? ";
									cin >> a9;
									if (a9 == 'S' || a9 == 's'){
										cout << "Non comprare un iPad.\n\n";
										system("pause");
										return 0;
									}
									else if (a9 == 'N' || a9 == 'n'){
										char b1;
										cout << "Hai 500 euro? ";
										cin>>b1;
										if (b1 == 'N' || b1 == 'n'){
											cout << "Non comprare un iPad.\n\n";
											system("pause");
											return 0;
										}
										else if (b1 == 'S' || b1 == 's'){
											cout << "Compra un portatile.\n\n";
											system("pause");
											return 0;
										}
									}
								}
								else if (a8 == 'S' || a8 == 's'){
									cout << "Non comprare un iPad.\n\n";
									system("pause");
									return 0;
								}
							}
							else if (a7 == 'S' || a7 == 's'){
								cout << "Comprane 2.\n\n";
								system("pause");
								return 0;
							}
						}
						else if (a6 == 's' || a6 == 'S'){
							goto Scelte;
						}
					}
					else if (a5 == 's' || a5 == 'S'){
						cout << "Chiedi aiuto a un professionista. ";
						system("pause");
						return 0;
					}
				}
			}
			else if (a3 == 's' || a3 == 'S'){
				goto Sicuro;
			}
		}else if (a2 == 's' || a2 == 'S'){
			char b2;
			Sicuro:
			cout << "Sicuro che non sei ricco? ";
			cin >> b2;
			if (b2 == 's' || b2 == 'S'){
				cout << "Chiedi a chi ti ha preso il Mac o l'iPhone di prenderti l'iPad.\n\n";
				system("pause");
				return 0;
			}
			else if (b2 == 'N' || b2 == 'n'){
				goto Ricco;
			}
		}
	}else if (a1 == 's' || a1 == 'S'){
		cout << "Comprane 2.\n\n";
		system("pause");
		return 0;
	}

}