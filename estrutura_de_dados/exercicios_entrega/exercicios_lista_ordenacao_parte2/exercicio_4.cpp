#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de uma transação
struct Transacao {
    string descricao;
    float valor;

    Transacao(string desc, float val) : descricao(desc), valor(val) {}
};

// Função de ordenação Insertion Sort para ordenar as transações por valor monetário
void insertionSort(vector<Transacao>& transacoes) {
    int n = transacoes.size();
    for (int i = 1; i < n; ++i) {
        Transacao chave = transacoes[i];
        int j = i - 1;
        while (j >= 0 && transacoes[j].valor > chave.valor) {
            transacoes[j + 1] = transacoes[j];
            j = j - 1;
        }
        transacoes[j + 1] = chave;
    }
}

int main() {
    // Vetor de transações de exemplo
    vector<Transacao> transacoes = {
        Transacao("Compra de produto A", 50.0),
        Transacao("Pagamento de conta de luz", 120.0),
        Transacao("Transferência para amigo", 20.0),
        Transacao("Compra de produto B", 80.0),
        Transacao("Depósito de salário", 1000.0)
    };

    // Ordenando as transações por valor monetário usando Insertion Sort
    insertionSort(transacoes);

    // Imprimindo as transações ordenadas
    cout << "Transações ordenadas por valor monetário:" << endl;
    for (const auto& transacao : transacoes) {
        cout << transacao.descricao << " - Valor: R$" << transacao.valor << endl;
    }

    return 0;
}
