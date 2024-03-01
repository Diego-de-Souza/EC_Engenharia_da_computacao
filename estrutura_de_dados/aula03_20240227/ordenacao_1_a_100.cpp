#include <cstdio>
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(){

    double numerosAleatorios;
    unsigned seed = time(0);
    srand(seed);   

    
    numerosAleatorios= rand()%100;
     
    double numerorealAleatorio = (double)rand() / RAND_MAX * 100;
    
    cout << numerosAleatorios << endl;
    cout << numerorealAleatorio << endl;

}