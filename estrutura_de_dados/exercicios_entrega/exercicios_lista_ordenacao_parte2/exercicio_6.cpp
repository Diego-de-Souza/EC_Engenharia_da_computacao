#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de uma tarefa
struct Tarefa {
    string descricao;
    int prioridade;

    // Construtor padrão
    Tarefa() : descricao(""), prioridade(0) {}

    Tarefa(string desc, int prio) : descricao(desc), prioridade(prio) {}
};

// Função para mesclar dois subvetores ordenados
void merge(vector<Tarefa>& arr, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;

    // Criar vetores temporários
    vector<Tarefa> L(n1);
    vector<Tarefa> R(n2);

    // Copiar os dados para os vetores temporários L[] e R[]
    for (int i = 0; i < n1; i++)
        L[i] = arr[l + i];
    for (int j = 0; j < n2; j++)
        R[j] = arr[m + 1 + j];

    // Mesclar os vetores temporários de volta ao vetor original arr[l..r]
    int i = 0;
    int j = 0;
    int k = l;

    while (i < n1 && j < n2) {
        if (L[i].prioridade <= R[j].prioridade) {
            arr[k] = L[i];
            i++;
        }
        else {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    // Copiar os elementos restantes de L[], se houver algum
    while (i < n1) {
        arr[k] = L[i];
        i++;
        k++;
    }

    // Copiar os elementos restantes de R[], se houver algum
    while (j < n2) {
        arr[k] = R[j];
        j++;
        k++;
    }
}

// Função principal que ordena o vetor arr[l..r] usando o algoritmo Merge Sort
void mergeSort(vector<Tarefa>& arr, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSort(arr, l, m);
    mergeSort(arr, m + 1, r);
    merge(arr, l, m, r);
}

int main() {
    // Vetor de tarefas de exemplo
    vector<Tarefa> tarefas = {
        Tarefa("Estudar para o exame", 2),
        Tarefa("Fazer compras", 1),
        Tarefa("Preparar apresentação", 3),
        Tarefa("Limpar a casa", 2),
        Tarefa("Enviar e-mails", 1)
    };

    // Ordenando as tarefas por prioridade usando Merge Sort
    mergeSort(tarefas, 0, tarefas.size() - 1);

    // Imprimindo as tarefas ordenadas
    cout << "Tarefas ordenadas por prioridade:" << endl;
    for (const auto& tarefa : tarefas) {
        cout << "Prioridade " << tarefa.prioridade << ": " << tarefa.descricao << endl;
    }

    return 0;
}
