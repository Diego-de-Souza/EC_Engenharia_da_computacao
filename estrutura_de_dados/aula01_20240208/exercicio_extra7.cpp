/******************************************************************************
Implemente uma função para calcular a média móvel de demanda de um produto. Dados de 
demanda mensal estão em uma lista. A média móvel deve ser calculada para um período
definido pelo usuário, por exemplo, 3 meses.
a. calcule a média móvel para o período escolhido.
b. gere um novo vetor com os valores da média móvel

*******************************************************************************/
#include <iostream>
#include <vector>

using namespace std;

// Função para calcular a média móvel de demanda
vector<double> calcularMediaMovel(vector<double> demanda, int periodo) {
  vector<double> mediaMovel;
  for (int i = 0; i < demanda.size() - periodo + 1; i++) {
    double soma = 0;
    for (int j = i; j < i + periodo; j++) {
      soma += demanda[j];
    }
    mediaMovel.push_back(soma / periodo);
  }
  return mediaMovel;
}

// Função para gerar um novo vetor com os valores da média móvel
vector<double> gerarVetorMediaMovel(vector<double> demanda, int periodo) {
  vector<double> mediaMovel = calcularMediaMovel(demanda, periodo);
  vector<double> vetorMediaMovel;
  for (int i = 0; i < demanda.size(); i++) {
    if (i < periodo - 1) {
      vetorMediaMovel.push_back(0);
    } else {
      vetorMediaMovel.push_back(mediaMovel[i - periodo + 1]);
    }
  }
  return vetorMediaMovel;
}

int main() {
  // Dados de demanda mensal
  vector<double> demanda = {100, 120, 150, 180, 200, 220, 250, 280, 300};

  // Período para o qual a média móvel deve ser calculada
  int periodo = 3;

  // Calcula a média móvel
  vector<double> mediaMovel = calcularMediaMovel(demanda, periodo);

  // Gera um novo vetor com os valores da média móvel
  vector<double> vetorMediaMovel = gerarVetorMediaMovel(demanda, periodo);

  // Imprime os resultados
  cout << "Demanda:" << endl;
  for (int i = 0; i < demanda.size(); i++) {
    cout << demanda[i] << " ";
  }
  cout << endl;

  cout << "Média móvel:" << endl;
  for (int i = 0; i < mediaMovel.size(); i++) {
    cout << mediaMovel[i] << " ";
  }
  cout << endl;

  cout << "Vetor média móvel:" << endl;
  for (int i = 0; i < vetorMediaMovel.size(); i++) {
    cout << vetorMediaMovel[i] << " ";
  }
  cout << endl;

  return 0;
}