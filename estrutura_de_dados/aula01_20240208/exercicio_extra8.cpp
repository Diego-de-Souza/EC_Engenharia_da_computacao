/******************************************************************************
Elabore uma função que analise a variação cambial de uma moeda em relação a outra. A 
função deverá receber dois vetores, sendo um com os valores históricos da moeda base e 
outro com valores da moeda de comparação, ambas no mesmo período.
a. calcule a variação percentual diária.
b. identifique os dias com maior e menor variação.

*******************************************************************************/
#include <iostream>
#include <vector>

using namespace std;

// Função para calcular a variação percentual diária
vector<double> calcularVariacaoPercentualDiaria(vector<double> moedaBase, vector<double> moedaComparacao) {
  vector<double> variacaoPercentualDiaria;
  for (int i = 1; i < moedaBase.size(); i++) {
    double variacao = (moedaBase[i] - moedaBase[i - 1]) / moedaBase[i - 1] * 100;
    variacaoPercentualDiaria.push_back(variacao);
  }
  return variacaoPercentualDiaria;
}

// Função para identificar os dias com maior e menor variação
pair<int, int> identificarDiasComMaiorEMenorVariacao(vector<double> variacaoPercentualDiaria) {
  int diaMaiorVariacao = 0;
  int diaMenorVariacao = 0;
  double maiorVariacao = variacaoPercentualDiaria[0];
  double menorVariacao = variacaoPercentualDiaria[0];
  for (int i = 1; i < variacaoPercentualDiaria.size(); i++) {
    if (variacaoPercentualDiaria[i] > maiorVariacao) {
      maiorVariacao = variacaoPercentualDiaria[i];
      diaMaiorVariacao = i;
    }
    if (variacaoPercentualDiaria[i] < menorVariacao) {
      menorVariacao = variacaoPercentualDiaria[i];
      diaMenorVariacao = i;
    }
  }
  return make_pair(diaMaiorVariacao, diaMenorVariacao);
}

int main() {
  // Valores históricos da moeda base
  vector<double> moedaBase = {1.0, 1.02, 1.04, 1.06, 1.08, 1.10, 1.12, 1.14, 1.16, 1.18};

  // Valores da moeda de comparação
  vector<double> moedaComparacao = {1.20, 1.22, 1.24, 1.26, 1.28, 1.30, 1.32, 1.34, 1.36, 1.38};

  // Calcula a variação percentual diária
  vector<double> variacaoPercentualDiaria = calcularVariacaoPercentualDiaria(moedaBase, moedaComparacao);

  // Identifica os dias com maior e menor variação
  pair<int, int> diasComMaiorEMenorVariacao = identificarDiasComMaiorEMenorVariacao(variacaoPercentualDiaria);

  // Imprime os resultados
  cout << "Variação percentual diária:" << endl;
  for (int i = 0; i < variacaoPercentualDiaria.size(); i++) {
    cout << variacaoPercentualDiaria[i] << "%" << endl;
  }

  cout << "Dia com maior variação: " << diasComMaiorEMenorVariacao.first << endl;
  cout << "Dia com menor variação: " << diasComMaiorEMenorVariacao.second << endl;

  return 0;
}