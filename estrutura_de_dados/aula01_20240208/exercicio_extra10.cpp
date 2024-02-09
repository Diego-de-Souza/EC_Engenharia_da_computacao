/******************************************************************************
Elabore um software de conversão que realize mudança entre bases numéricas.
a. realize mudança de base entre 2 e 10.
*******************************************************************************/
#include <iostream>
#include <string>

using namespace std;

// Função para converter um número de base 2 para base 10
int converterBase2ParaBase10(string numeroBase2) {
  int numeroBase10 = 0;
  int potencia = 1;

  for (int i = numeroBase2.length() - 1; i >= 0; i--) {
    if (numeroBase2[i] == '1') {
      numeroBase10 += potencia;
    }
    potencia *= 2;
  }

  return numeroBase10;
}

// Função para converter um número de base 10 para base 2
string converterBase10ParaBase2(int numeroBase10) {
  string numeroBase2 = "";

  while (numeroBase10 > 0) {
    if (numeroBase10 % 2 == 0) {
      numeroBase2 = '0' + numeroBase2;
    } else {
      numeroBase2 = '1' + numeroBase2;
    }
    numeroBase10 /= 2;
  }

  return numeroBase2;
}

int main() {
  // Número a ser convertido
  string numeroBase2 = "101110";

  // Converte o número de base 2 para base 10
  int numeroBase10 = converterBase2ParaBase10(numeroBase2);

  // Converte o número de base 10 para base 2
  string numeroBase2Convertido = converterBase10ParaBase2(numeroBase10);

  // Imprime os resultados
  cout << "Número em base 2: " << numeroBase2 << endl;
  cout << "Número em base 10: " << numeroBase10 << endl;
  cout << "Número em base 2 convertido: " << numeroBase2Convertido << endl;

  return 0;
}