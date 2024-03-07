#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Função para mesclar dois subvetores ordenados
void merge(vector<string>& arr, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;

    // Criar vetores temporários
    vector<string> L(n1);
    vector<string> R(n2);

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
        if (L[i] <= R[j]) {
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
void mergeSort(vector<string>& arr, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSort(arr, l, m);
    mergeSort(arr, m + 1, r);
    merge(arr, l, m, r);
}

int main() {
    // Vetor de nomes de arquivos de exemplo
    vector<string> fotos = {"foto3.jpg", "foto1.jpg", "foto5.jpg", "foto2.jpg", "foto4.jpg"};

    // Ordenando os nomes de arquivo por ordem alfabética
    mergeSort(fotos, 0, fotos.size() - 1);

    // Imprimindo os nomes de arquivo ordenados
    cout << "Fotos ordenadas por ordem alfabética:" << endl;
    for (const string& foto : fotos) {
        cout << foto << endl;
    }

    return 0;
}
