#include <cstdio>
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <algorithm>
#include <chrono>

using namespace std;

int main(){

    double numerosAleatorios[100] = {};
    unsigned seed = time(0);
    srand(seed);   
    double aux;

    //inicia a contagem 
    auto start = std::chrono::high_resolution_clock::now();

    for(int i=0; i < 100;i++){
        numerosAleatorios[i]= rand()%1000;
        cout << numerosAleatorios[i] << " | ";
        
    }
    cout << endl;
    
    //finaliza a contagem
    auto end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double, std::milli> elapsed_time = end - start;
    std::cout << "Tempo de execução para geração: " << elapsed_time.count() << " ms" << std::endl;
    
    //inicia a contagem 2
    auto start1 = std::chrono::high_resolution_clock::now();

    for(int i=0; i< 100;i++){
        for(int j=0; j < 99;j++){
            if(numerosAleatorios[j] > numerosAleatorios[j+1]){
                aux=numerosAleatorios[j];
                numerosAleatorios[j] = numerosAleatorios[j+1];
                numerosAleatorios[j+1] = aux;
            }
        }
    }
    //finaliza a contagem 2
    auto end1 = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double, std::milli> elapsed_time1 = end1 - start1;
    
    for (int i=0; i<100; i++){
        cout << numerosAleatorios[i] << " | ";
    }
    cout << endl;
    
    std::cout << "Tempo de execução para ordenação: " << elapsed_time1.count() << " ms" << std::endl;
    std::cout << "Tempo de execução Total: " << elapsed_time.count()+elapsed_time1.count() << " ms" << std::endl;

    return 0;
}