#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Estrutura para representar um evento
struct Evento {
    string nome;
    string data;
    string hora;

    Evento(string nome, string data, string hora) : nome(nome), data(data), hora(hora) {}
};

// Função de ordenação utilizando o algoritmo Insertion Sort para ordenar os eventos por data e hora
void insertionSort(vector<Evento>& eventos) {
    int n = eventos.size();
    for (int i = 1; i < n; i++) {
        Evento chave = eventos[i];
        int j = i - 1;

        // Move os elementos do vetor que são maiores que a chave para uma posição à frente de sua posição atual
        while (j >= 0 && eventos[j].data > chave.data) {
            eventos[j + 1] = eventos[j];
            j = j - 1;
        }
        while (j >= 0 && eventos[j].data == chave.data && eventos[j].hora > chave.hora) {
            eventos[j + 1] = eventos[j];
            j = j - 1;
        }
        eventos[j + 1] = chave;
    }
}

int main() {
    // Vetor de eventos de exemplo
    vector<Evento> eventos = {
        Evento("Evento A", "2024-03-10", "10:00"),
        Evento("Evento B", "2024-03-09", "15:00"),
        Evento("Evento C", "2024-03-11", "08:30"),
        Evento("Evento D", "2024-03-09", "10:30"),
        Evento("Evento E", "2024-03-10", "08:00")
    };

    // Ordenando os eventos por data e hora usando Insertion Sort
    insertionSort(eventos);

    // Imprimindo os eventos ordenados
    cout << "Eventos ordenados por data e hora:" << endl;
    for (const auto& evento : eventos) {
        cout << "Nome: " << evento.nome << ", Data: " << evento.data << ", Hora: " << evento.hora << endl;
    }

    return 0;
}
