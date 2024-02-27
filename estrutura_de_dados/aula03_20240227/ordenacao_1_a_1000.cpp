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
    cout << aux = sizeof(numerosAleatorios) << endl;
/*
    for(int i=0; i< 10;i++){
        for(int j=0; j < 9;j++){
            if(numerosAleatorios[j] > numerosAleatorios[j+1]){
                aux=numerosAleatorios[j];
                numerosAleatorios[j] = numerosAleatorios[j+1];
                numerosAleatorios[j+1] = aux;
            }
        }
    }

    cout << sizeof(numerosAleatorios) << endl;
    
    for (int i=0; i<10; i++){
        cout << numerosAleatorios[i] << " | ";
    }
    cout << endl;

    return 0;


double notas[10] = {5.5,9.8,6.4,4.1,5.2,8.2,4.8,7.3,8.4,9.1};
    double aux;

    /////////////bubble sort ////////////
    for(int i=0; i < 10; i++){
        for(int j=0;j < 9; j++ ){
            if(notas[j] > notas[j+1]){
                aux=notas[j];
                notas[j] = notas[j+1];
                notas[j+1] = aux;
            }
        }
    }
    ////////////////////////////////////
    for (int i=0; i<10; i++){
        cout << notas [i] << " | ";
    }
    cout << endl;
*/
    return 0;
}