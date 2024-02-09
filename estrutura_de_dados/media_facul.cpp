#include <iostream>

using namespace std;

int main (){
    cout << "Digite o valor da N1 da M1: " << endl;
    int notaN1M1 = 0.0;
    cin >> notaN1M1;
    cout << "Digite o valor da N2 da M1: " << endl;
    float notaN2M1 = 0.0;
    cin >> notaN2M1;
    cout << "Digite o valor da N1 da M2: " << endl;
    float notaN1M2 = 0.0;
    cin >> notaN1M2;
    cout << "Digite o valor da N2 da M2: " << endl;
    float notaN2M2 = 0.0;
    cin >> notaN2M2;
    cout << "Digite o valor da Formativa: " << endl;
    float formativa = 0.0;
    cin >> formativa;
    float resultado = ((notaN1M1*0.40)+(notaN2M1*0.6)) //+ ((((notaN1M2*0.8)+(formativa*0.2))*0.4)+(notaN2M2*0.60))*0.5;
    cout << "sua média é: " << resultado << endl;
}