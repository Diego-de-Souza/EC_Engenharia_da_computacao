/******************************************************************************
Crie um vetor denominado mercado_acoes, sendo que cada posição deverá conter um objeto 
com o nome de uma empresa, preço da ação, volume negociado e capitalização de mercado.
a. escreva um código para listar as empresas com capitalização de mercado acima de um 
certo valor.

*******************************************************************************/

#include <iostream>
#include <vector>

using namespace std;

// Estrutura para representar uma empresa
struct Empresa {
  string nome;
  double precoAcao;
  double volumeNegociado;
  double capitalizacaoMercado;
};

// Função para listar as empresas com capitalização de mercado acima de um certo valor
void listarEmpresas(vector<Empresa> mercado_acoes, double valorMinimo) {
  for (int i = 0; i < mercado_acoes.size(); i++) {
    if (mercado_acoes[i].capitalizacaoMercado > valorMinimo) {
      cout << mercado_acoes[i].nome << endl;
    }
  }
}

int main() {
  // Cria o vetor de empresas
  vector<Empresa> mercado_acoes = {
    {"Petrobras", 25.0, 1000000, 1000000000},
    {"Vale", 30.0, 500000, 500000000},
    {"Itaú Unibanco", 40.0, 250000, 250000000},
    {"Bradesco", 35.0, 200000, 200000000},
    {"Ambev", 50.0, 150000, 150000000}
  };

  // Lista as empresas com capitalização de mercado acima de 500 milhões
  listarEmpresas(mercado_acoes, 500000000);

  return 0;
}