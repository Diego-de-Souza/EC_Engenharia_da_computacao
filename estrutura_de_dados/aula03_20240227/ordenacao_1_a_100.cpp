#include <cstdio>
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, int argv){

    double numerosAleatorios[10] = {};
    unsigned seed = time(0);
    srand(seed);   
    double aux;

    for(int i=0; 1 < 10;i++){
        numerosAleatorios[i]= rand()%100;
        cout << numerosAleatorios[i] << " | ";
        
    }
    cout << endl;


}