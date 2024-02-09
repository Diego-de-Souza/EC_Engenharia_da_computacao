/******************************************************************************

 * EX 
 * Crie um vetor denominado dados_economicos, sendo que cada objeto deverá ser um país
 * com as respectivas informações de nome, PIB, taxa de inflação e taxa de desemprego.
 * a. escreva uma função para encontrar o país com o maior PIB.
 * b. escreva uma função para calcular a média de inflação entre os países.


*******************************************************************************/

#include <iostream>
#include <vector>

using namespace std;

// Estrutura para representar um país
struct Pais {
  string nome;
  double pib;
  double inflacao;
  double desemprego;
};

// Função para encontrar o país com o maior PIB
Pais encontrarMaiorPIB(vector<Pais> paises) {
  Pais maiorPIB = paises[0];
  for (int i = 1; i < paises.size(); i++) {
    if (paises[i].pib > maiorPIB.pib) {
      maiorPIB = paises[i];
    }
  }
  return maiorPIB;
}

// Função para calcular a média de inflação entre os países
double calcularMediaInflacao(vector<Pais> paises) {
  double somaInflacao = 0;
  for (int i = 0; i < paises.size(); i++) {
    somaInflacao += paises[i].inflacao;
  }
  return somaInflacao / paises.size();
}

int main() {
  // Cria o vetor de países
  vector<Pais> dados_economicos = {
    {"Brasil", 1.442, 10.06, 11.2},
    {"Estados Unidos", 20.89, 7.9, 3.9},
    {"China", 14.72, 2.5, 4.0},
    {"Japão", 5.06, 0.5, 2.8},
    {"Alemanha", 3.85, 7.9, 5.7}
  };

  // Encontra o país com o maior PIB
  Pais maiorPIB = encontrarMaiorPIB(dados_economicos);

  // Calcula a média de inflação entre os países
  double mediaInflacao = calcularMediaInflacao(dados_economicos);

  // Imprime os resultados
  cout << "País com o maior PIB: " << maiorPIB.nome << endl;
  cout << "Média de inflação: " << mediaInflacao << endl;

  return 0;
}