/******************************************************************************
Elabore uma função para analisar uma carteira de investimentos. A carteira é representada 
por um vetor com os nomes dos ativos, os valores do preço de compra, quantidade e preço 
atual do ativo.
a. calcule o valor total investido e o valor total atual da carteira.
b. determine o retorno total em percentual.

*******************************************************************************/
#include <iostream>
#include <vector>

using namespace std;

// Estrutura para representar um ativo
struct Ativo {
  string nome;
  double precoCompra;
  int quantidade;
  double precoAtual;
};

// Função para calcular o valor total investido
double calcularValorTotalInvestido(vector<Ativo> carteira) {
  double valorTotalInvestido = 0;
  for (int i = 0; i < carteira.size(); i++) {
    valorTotalInvestido += carteira[i].precoCompra * carteira[i].quantidade;
  }
  return valorTotalInvestido;
}

// Função para calcular o valor total atual da carteira
double calcularValorTotalAtual(vector<Ativo> carteira) {
  double valorTotalAtual = 0;
  for (int i = 0; i < carteira.size(); i++) {
    valorTotalAtual += carteira[i].precoAtual * carteira[i].quantidade;
  }
  return valorTotalAtual;
}

// Função para calcular o retorno total em percentual
double calcularRetornoTotal(double valorTotalInvestido, double valorTotalAtual) {
  double retornoTotal = (valorTotalAtual - valorTotalInvestido) / valorTotalInvestido * 100;
  return retornoTotal;
}

int main() {
  // Cria a carteira de investimentos
  vector<Ativo> carteira = {
    {"Petrobras", 25.0, 100, 30.0},
    {"Vale", 30.0, 50, 35.0},
    {"Itaú Unibanco", 40.0, 25, 45.0},
    {"Bradesco", 35.0, 20, 40.0},
    {"Ambev", 50.0, 15, 55.0}
  };

  // Calcula o valor total investido
  double valorTotalInvestido = calcularValorTotalInvestido(carteira);

  // Calcula o valor total atual da carteira
  double valorTotalAtual = calcularValorTotalAtual(carteira);

  // Calcula o retorno total em percentual
  double retornoTotal = calcularRetornoTotal(valorTotalInvestido, valorTotalAtual);

  // Imprime os resultados
  cout << "Valor total investido: " << valorTotalInvestido << endl;
  cout << "Valor total atual da carteira: " << valorTotalAtual << endl;
  cout << "Retorno total em percentual: " << retornoTotal << "%" << endl;

  return 0;
}