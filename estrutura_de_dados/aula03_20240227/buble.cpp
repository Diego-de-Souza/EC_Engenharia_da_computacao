#include <cstdio>
#include <iostream>

using namespace std;

int main (int argc , char** argv){

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

    return 0;
}