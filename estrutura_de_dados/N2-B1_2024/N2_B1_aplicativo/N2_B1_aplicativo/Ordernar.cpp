#include "Ordenar.h"
#include <string>
#include "Pessoa.h"

// Fun��o swap para trocar dois objetos Pessoa
void swap(Pessoa* xp, Pessoa* yp) {
    Pessoa temp = *xp;
    *xp = *yp;
    *yp = temp;
}

// Fun��o de Bubble Sort para ordenar um array de objetos Pessoa por nome
void bubbleSort(Pessoa arr[], int n) {
    int i, j;
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - i - 1; j++) {
            // Compara dois objetos Pessoa pelo nome e os troca se estiverem fora de ordem
            if (arr[j].getNome() > arr[j + 1].getNome()) {
                swap(&arr[j], &arr[j + 1]);
            }
        }
    }
}

// Fun��o de Insertion Sort para ordenar um array de objetos Pessoa por nome
void insertionSort(Pessoa arr[], int n) {
    int i, j;
    Pessoa chave;
    for (i = 1; i < n; i++) {
        chave = arr[i];
        j = i - 1;

        // Move os elementos de arr[0..i-1], que s�o maiores que a chave, uma posi��o � frente de sua posi��o atual
        while (j >= 0 && arr[j].getNome() > chave.getNome()) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = chave;
    }
}

// Fun��o de Selection Sort para ordenar um array de objetos Pessoa por nome
void selectionSort(Pessoa arr[], int n) {
    int i, j, min_idx;
    for (i = 0; i < n - 1; i++) {
        min_idx = i;
        for (j = i + 1; j < n; j++)
            if (arr[j].getNome() < arr[min_idx].getNome())
                min_idx = j;
        swap(&arr[min_idx], &arr[i]);
    }
}

// Fun��o para mesclar dois subvetores de arr[]
void merge(std::vector<Pessoa>& arr, int l, int m, int r) {
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;

    // Vetores tempor�rios para armazenar os elementos da mesclagem
    std::vector<Pessoa> L(n1), R(n2);

    // Copia os dados para os vetores tempor�rios L[] e R[]
    for (i = 0; i < n1; i++)
        L[i] = arr[l + i];
    for (j = 0; j < n2; j++)
        R[j] = arr[m + 1 + j];

    // Mescla os vetores tempor�rios de volta em arr[l..r]
    i = 0;
    j = 0;
    k = l;
    while (i < n1 && j < n2) {
        if (L[i].getNome() <= R[j].getNome()) {
            arr[k] = L[i];
            i++;
        }
        else {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    // Copia os elementos restantes de L[], se houver algum
    while (i < n1) {
        arr[k] = L[i];
        i++;
        k++;
    }

    // Copia os elementos restantes de R[], se houver algum
    while (j < n2) {
        arr[k] = R[j];
        j++;
        k++;
    }
}

// Fun��o principal que implementa o algoritmo Merge Sort
void mergeSort(std::vector<Pessoa>& arr, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSort(arr, l, m);
    mergeSort(arr, m + 1, r);
    merge(arr, l, m, r);
}

// Fun��o para particionar o vetor usando o �ltimo elemento como piv�
int partition(std::vector<Pessoa>& arr, int low, int high) {
    Pessoa pivot = arr[high]; // Piv�
    int i = (low - 1); // �ndice do menor elemento

    for (int j = low; j <= high - 1; j++) {
        // Se o elemento atual for menor ou igual ao piv�
        if (arr[j].getNome() <= pivot.getNome()) {
            i++; // Incrementa o �ndice do menor elemento
            swap(&arr[i], &arr[j]);
        }
    }
    swap(&arr[i + 1], &arr[high]);
    return (i + 1);
}

// Fun��o principal que implementa o algoritmo Quick Sort
void quickSort(std::vector<Pessoa>& arr, int low, int high) {
    if (low < high) {
        // �ndice da parti��o
        int pi = partition(arr, low, high);

        // Ordena os elementos antes e depois da parti��o recursivamente
        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}
