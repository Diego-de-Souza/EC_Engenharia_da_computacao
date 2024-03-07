#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// Definição da classe Produto
class Produto {
public:
    string nome;
    int estoque;

    Produto(string nome, int estoque) {
        this->nome = nome;
        this->estoque = estoque;
    }
};

// Função de comparação para ordenar os produtos por nível de estoque
bool compararPorEstoque(const Produto& a, const Produto& b) {
    return a.estoque < b.estoque;
}

// Função para ordenar os produtos por nível de estoque usando o algoritmo Selection Sort
void ordenarProdutosPorEstoque(vector<Produto>& produtos) {
    sort(produtos.begin(), produtos.end(), compararPorEstoque);
}

int main() {
    // Criando uma lista de produtos de exemplo
    vector<Produto> produtos = {
        Produto("Produto 1", 10),
        Produto("Produto 2", 5),
        Produto("Produto 3", 20),
        Produto("Produto 4", 15),
        Produto("Produto 5", 8)
    };

    // Ordenando os produtos por nível de estoque
    ordenarProdutosPorEstoque(produtos);

    // Imprimindo os produtos ordenados
    cout << "Produtos ordenados por nível de estoque:" << endl;
    for (const Produto& produto : produtos) {
        cout << produto.nome << " - Estoque: " << produto.estoque << endl;
    }

    return 0;
}
