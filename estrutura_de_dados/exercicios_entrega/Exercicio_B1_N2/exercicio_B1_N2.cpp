#include <iostream>
#include <vector>
#include <chrono>
#include <algorithm>
#include <cmath>

using namespace std;
using namespace std::chrono;

// Classe Pessoa com atributos correspondentes aos dados do arquivo Excel
class Pessoa {
public:
    string nome;
    int idade;
    float altura;

    Pessoa(string n, int i, float a) : nome(n), idade(i), altura(a) {}
};

// Função para calcular a média de um atributo numérico
template<typename T>
double calcularMedia(const vector<T>& dados) {
    double soma = 0;
    for (const auto& valor : dados) {
        soma += valor;
    }
    return soma / dados.size();
}

// Função para calcular a mediana de um atributo numérico
template<typename T>
double calcularMediana(vector<T>& dados) {
    size_t n = dados.size();
    sort(dados.begin(), dados.end());
    if (n % 2 == 0) {
        return (dados[n / 2 - 1] + dados[n / 2]) / 2.0;
    } else {
        return dados[n / 2];
    }
}

// Função para calcular o desvio padrão de um atributo numérico
template<typename T>
double calcularDesvioPadrao(const vector<T>& dados) {
    double media = calcularMedia(dados);
    double soma = 0;
    for (const auto& valor : dados) {
        soma += pow(valor - media, 2);
    }
    double variancia = soma / dados.size();
    return sqrt(variancia);
}

// Implementação dos algoritmos de ordenação

// Bubble Sort
template<typename T>
void bubbleSort(vector<T>& dados) {
    int n = dados.size();
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (dados[j] > dados[j + 1]) {
                swap(dados[j], dados[j + 1]);
            }
        }
    }
}

// Insertion Sort
template<typename T>
void insertionSort(vector<T>& dados) {
    int n = dados.size();
    for (int i = 1; i < n; i++) {
        T chave = dados[i];
        int j = i - 1;
        while (j >= 0 && dados[j] > chave) {
            dados[j + 1] = dados[j];
            j--;
        }
        dados[j + 1] = chave;
    }
}

// Selection Sort
template<typename T>
void selectionSort(vector<T>& dados) {
    int n = dados.size();
    for (int i = 0; i < n - 1; i++) {
        int min_idx = i;
        for (int j = i + 1; j < n; j++) {
            if (dados[j] < dados[min_idx]) {
                min_idx = j;
            }
        }
        swap(dados[min_idx], dados[i]);
    }
}

// Merge Sort
template<typename T>
void merge(vector<T>& dados, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;
    vector<T> L(n1), R(n2);
    for (int i = 0; i < n1; i++) {
        L[i] = dados[l + i];
    }
    for (int j = 0; j < n2; j++) {
        R[j] = dados[m + 1 + j];
    }
    int i = 0, j = 0, k = l;
    while (i < n1 && j < n2) {
        if (L[i] <= R[j]) {
            dados[k] = L[i];
            i++;
        } else {
            dados[k] = R[j];
            j++;
        }
        k++;
    }
    while (i < n1) {
        dados[k] = L[i];
        i++;
        k++;
    }
    while (j < n2) {
        dados[k] = R[j];
        j++;
        k++;
    }
}

template<typename T>
void mergeSort(vector<T>& dados, int l, int r) {
    if (l >= r) {
        return;
    }
    int m = l + (r - l) / 2;
    mergeSort(dados, l, m);
    mergeSort(dados, m + 1, r);
    merge(dados, l, m, r);
}

// Quick Sort
template<typename T>
int partition(vector<T>& dados, int low, int high) {
    T pivot = dados[high];
    int i = low - 1;
    for (int j = low; j <= high - 1; j++) {
        if (dados[j] < pivot) {
            i++;
            swap(dados[i], dados[j]);
        }
    }
    swap(dados[i + 1], dados[high]);
    return i + 1;
}

template<typename T>
void quickSort(vector<T>& dados, int low, int high) {
    if (low < high) {
        int pi = partition(dados, low, high);
        quickSort(dados, low, pi - 1);
        quickSort(dados, pi + 1, high);
    }
}

int main() {
    // Vetor de dados de exemplo (idade)
    vector<int> idades = {30, 25, 40, 35, 20};

    // Calcular média, mediana e desvio padrão para a idade
    double mediaIdade = calcularMedia(idades);
    double medianaIdade = calcularMediana(idades);
    double desvioPadraoIdade = calcularDesvioPadrao(idades);

    // Imprimir resultados
    cout << "Média da Idade: " << mediaIdade << endl;
    cout << "Mediana da Idade: " << medianaIdade << endl;
    cout << "Desvio Padrão da Idade: " << desvioPadraoIdade << endl;

    return 0;
}
