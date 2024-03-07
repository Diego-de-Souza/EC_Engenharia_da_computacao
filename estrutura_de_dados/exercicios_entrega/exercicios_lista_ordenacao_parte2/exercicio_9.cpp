#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Definição da estrutura de um contato
struct Contato {
    string nome;
    string dataNascimento;

    // Construtor padrão
    Contato() {}

    // Construtor com parâmetros
    Contato(string nome, string dataNascimento) : nome(nome), dataNascimento(dataNascimento) {}
};

// Função para mesclar dois subvetores ordenados por nome
void mergePorNome(vector<Contato>& contatos, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;

    // Criar vetores temporários
    vector<Contato> L(n1);
    vector<Contato> R(n2);

    // Copiar os dados para os vetores temporários L[] e R[]
    for (int i = 0; i < n1; i++)
        L[i] = contatos[l + i];
    for (int j = 0; j < n2; j++)
        R[j] = contatos[m + 1 + j];

    // Mesclar os vetores temporários de volta ao vetor original contatos[l..r]
    int i = 0;
    int j = 0;
    int k = l;

    while (i < n1 && j < n2) {
        if (L[i].nome <= R[j].nome) {
            contatos[k] = L[i];
            i++;
        }
        else {
            contatos[k] = R[j];
            j++;
        }
        k++;
    }

    // Copiar os elementos restantes de L[], se houver algum
    while (i < n1) {
        contatos[k] = L[i];
        i++;
        k++;
    }

    // Copiar os elementos restantes de R[], se houver algum
    while (j < n2) {
        contatos[k] = R[j];
        j++;
        k++;
    }
}

// Função principal que ordena o vetor contatos[l..r] por nome usando o algoritmo Merge Sort
void mergeSortPorNome(vector<Contato>& contatos, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSortPorNome(contatos, l, m);
    mergeSortPorNome(contatos, m + 1, r);
    mergePorNome(contatos, l, m, r);
}

// Função para mesclar dois subvetores ordenados por data de nascimento
void mergePorDataNascimento(vector<Contato>& contatos, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;

    // Criar vetores temporários
    vector<Contato> L(n1);
    vector<Contato> R(n2);

    // Copiar os dados para os vetores temporários L[] e R[]
    for (int i = 0; i < n1; i++)
        L[i] = contatos[l + i];
    for (int j = 0; j < n2; j++)
        R[j] = contatos[m + 1 + j];

    // Mesclar os vetores temporários de volta ao vetor original contatos[l..r]
    int i = 0;
    int j = 0;
    int k = l;

    while (i < n1 && j < n2) {
        if (L[i].dataNascimento <= R[j].dataNascimento) {
            contatos[k] = L[i];
            i++;
        }
        else {
            contatos[k] = R[j];
            j++;
        }
        k++;
    }

    // Copiar os elementos restantes de L[], se houver algum
    while (i < n1) {
        contatos[k] = L[i];
        i++;
        k++;
    }

    // Copiar os elementos restantes de R[], se houver algum
    while (j < n2) {
        contatos[k] = R[j];
        j++;
        k++;
    }
}

// Função principal que ordena o vetor contatos[l..r] por data de nascimento usando o algoritmo Merge Sort
void mergeSortPorDataNascimento(vector<Contato>& contatos, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSortPorDataNascimento(contatos, l, m);
    mergeSortPorDataNascimento(contatos, m + 1, r);
    mergePorDataNascimento(contatos, l, m, r);
}

// Função para ordenar os contatos por nome e depois por data de nascimento
void ordenarContatos(vector<Contato>& contatos) {
    mergeSortPorNome(contatos, 0, contatos.size() - 1);
    mergeSortPorDataNascimento(contatos, 0, contatos.size() - 1);
}

int main() {
    // Vetor de contatos de exemplo
    vector<Contato> contatos = {
        Contato("Alice", "1990-01-15"),
        Contato("Bob", "1985-07-10"),
        Contato("Charlie", "1995-03-20"),
        Contato("David", "1992-11-25"),
        Contato("Eve", "1988-09-05")
    };

    // Ordenando os contatos por nome e data de nascimento usando Merge Sort
    ordenarContatos(contatos);

    // Imprimindo os contatos ordenados
    cout << "Contatos ordenados por nome e data de nascimento:" << endl;
    for (const auto& contato : contatos) {
        cout << "Nome: " << contato.nome << ", Data de Nascimento: " << contato.dataNascimento << endl;
    }

    return 0;
}
