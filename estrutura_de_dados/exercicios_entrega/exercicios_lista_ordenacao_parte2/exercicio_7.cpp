#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de uma música
struct Musica {
    string nome;
    string categoria;

    Musica(string nome, string categoria) : nome(nome), categoria(categoria) {}
};

// Função de ordenação Insertion Sort para ordenar a playlist de músicas por categoria
void insertionSort(vector<Musica>& playlist) {
    int n = playlist.size();
    for (int i = 1; i < n; ++i) {
        Musica chave = playlist[i];
        int j = i - 1;
        while (j >= 0 && playlist[j].categoria > chave.categoria) {
            playlist[j + 1] = playlist[j];
            j = j - 1;
        }
        playlist[j + 1] = chave;
    }
}

int main() {
    // Playlist de músicas de exemplo
    vector<Musica> playlist = {
        Musica("Song A", "Rock"),
        Musica("Song B", "Pop"),
        Musica("Song C", "Electronic"),
        Musica("Song D", "Rock"),
        Musica("Song E", "Pop")
    };

    // Ordenando a playlist de músicas por categoria usando Insertion Sort
    insertionSort(playlist);

    // Imprimindo a playlist ordenada
    cout << "Playlist ordenada por categoria:" << endl;
    for (const auto& musica : playlist) {
        cout << "Categoria: " << musica.categoria << ", Música: " << musica.nome << endl;
    }

    return 0;
}
