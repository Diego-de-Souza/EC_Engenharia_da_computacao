#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de um jogador
struct Jogador {
    string nome;
    int pontuacao;

    Jogador(string nome, int pontuacao) : nome(nome), pontuacao(pontuacao) {}
};

// Função de ordenação Selection Sort para ordenar os jogadores em ordem decrescente de pontuação
void selectionSort(vector<Jogador>& jogadores) {
    int n = jogadores.size();
    for (int i = 0; i < n - 1; i++) {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++) {
            if (jogadores[j].pontuacao > jogadores[maxIndex].pontuacao) {
                maxIndex = j;
            }
        }
        if (maxIndex != i) {
            // Troca os jogadores de posição
            Jogador temp = jogadores[i];
            jogadores[i] = jogadores[maxIndex];
            jogadores[maxIndex] = temp;
        }
    }
}

int main() {
    // Vetor de jogadores de exemplo
    vector<Jogador> jogadores = {
        Jogador("Jogador A", 100),
        Jogador("Jogador B", 80),
        Jogador("Jogador C", 120),
        Jogador("Jogador D", 90),
        Jogador("Jogador E", 110)
    };

    // Ordenando os jogadores em ordem decrescente de pontuação usando Selection Sort
    selectionSort(jogadores);

    // Imprimindo o ranking dos jogadores ordenados por pontuação
    cout << "Ranking dos jogadores por pontuação (em ordem decrescente):" << endl;
    for (int i = 0; i < jogadores.size(); ++i) {
        cout << i + 1 << ". " << jogadores[i].nome << " - Pontuação: " << jogadores[i].pontuacao << endl;
    }

    return 0;
}
