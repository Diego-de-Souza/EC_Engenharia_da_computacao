#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de um produto
struct Produto {
    string nome;
    float preco;

    Produto(string nome, float preco) : nome(nome), preco(preco) {}
};

// Função de ordenação Selection Sort para ordenar os produtos por preço em ordem crescente
void selectionSort(vector<Produto>& produtos) {
    int n = produtos.size();
    for (int i = 0; i < n - 1; i++) {
        int minIndex = i;
        for (int j = i + 1; j < n; j++) {
            if (produtos[j].preco < produtos[minIndex].preco) {
                minIndex = j;
            }
        }
        if (minIndex != i) {
            // Troca os produtos de posição
            Produto temp = produtos[i];
            produtos[i] = produtos[minIndex];
            produtos[minIndex] = temp;
        }
    }
}

int main() {
    // Vetor de produtos de exemplo
    vector<Produto> produtos = {
        Produto("Produto A", 50.0),
        Produto("Produto B", 30.0),
        Produto("Produto C", 80.0),
        Produto("Produto D", 20.0),
        Produto("Produto E", 60.0)
    };

    // Ordenando os produtos por preço em ordem crescente usando Selection Sort
    selectionSort(produtos);

    // Imprimindo os produtos ordenados por preço
    cout << "Produtos ordenados por preço em ordem crescente:" << endl;
    for (const auto& produto : produtos) {
        cout << produto.nome << " - Preço: R$" << produto.preco << endl;
    }

    return 0;
}
