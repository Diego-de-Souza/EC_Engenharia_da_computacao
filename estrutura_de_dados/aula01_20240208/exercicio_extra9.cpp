/******************************************************************************
Elabore uma função para calcular o ponto de equilíbrio de um produto. A função deve receber 
o custo fixo total, o preço de venda por unidade e o custo variável por unidade.
a. calcule quantas unidades precisam ser vendidas para atingir o ponto de equilíbrio.

*******************************************************************************/
#include <iostream>

using namespace std;

// Função para calcular o ponto de equilíbrio
int calcularPontoEquilibrio(double custoFixoTotal, double precoVendaPorUnidade, double custoVariavelPorUnidade) {
  // Calcula a margem de contribuição por unidade
  double margemContribuicaoPorUnidade = precoVendaPorUnidade - custoVariavelPorUnidade;

  // Calcula o ponto de equilíbrio
  int pontoEquilibrio = custoFixoTotal / margemContribuicaoPorUnidade;

  return pontoEquilibrio;
}

int main() {
  // Custo fixo total
  double custoFixoTotal = 10000;

  // Preço de venda por unidade
  double precoVendaPorUnidade = 20;

  // Custo variável por unidade
  double custoVariavelPorUnidade = 10;

  // Calcula o ponto de equilíbrio
  int pontoEquilibrio = calcularPontoEquilibrio(custoFixoTotal, precoVendaPorUnidade, custoVariavelPorUnidade);

  // Imprime o resultado
  cout << "Ponto de equilíbrio: " << pontoEquilibrio << " unidades" << endl;

  return 0;
}