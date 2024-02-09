/******************************************************************************

 Crie um vetor denominado relatorios, sendo que cada posição deverá representar um 
relatório econômico de um trimestre, contendo informações como PIB, exportações e 
importações.
a. calcule o crescimento do PIB trimestral.
b. gere um sumário que apresente a média das exportações e importações no ano.

*******************************************************************************/

#include <iostream>
#include <vector>

using namespace std;

// Estrutura para representar um relatório econômico trimestral
struct RelatorioEconomico {
  double pib;
  double exportacoes;
  double importacoes;
};

// Função para calcular o crescimento do PIB trimestral
double calcularCrescimentoPIB(vector<RelatorioEconomico> relatorios) {
  double crescimentoPIB = 0;
  for (int i = 1; i < relatorios.size(); i++) {
    crescimentoPIB += (relatorios[i].pib - relatorios[i - 1].pib) / relatorios[i - 1].pib;
  }
  return crescimentoPIB;
}

// Função para gerar um sumário com a média das exportações e importações no ano
void gerarSumario(vector<RelatorioEconomico> relatorios) {
  double somaExportacoes = 0;
  double somaImportacoes = 0;
  for (int i = 0; i < relatorios.size(); i++) {
    somaExportacoes += relatorios[i].exportacoes;
    somaImportacoes += relatorios[i].importacoes;
  }
  double mediaExportacoes = somaExportacoes / relatorios.size();
  double mediaImportacoes = somaImportacoes / relatorios.size();

  cout << "Média das exportações no ano: " << mediaExportacoes << endl;
  cout << "Média das importações no ano: " << mediaImportacoes << endl;
}

int main() {
  // Cria o vetor de relatórios econômicos trimestrais
  vector<RelatorioEconomico> relatorios = {
    {1.442, 100.0, 50.0},
    {1.460, 110.0, 60.0},
    {1.478, 120.0, 70.0},
    {1.496, 130.0, 80.0}
  };

  // Calcula o crescimento do PIB trimestral
  double crescimentoPIB = calcularCrescimentoPIB(relatorios);

  // Gera um sumário com a média das exportações e importações no ano
  gerarSumario(relatorios);

  return 0;
}