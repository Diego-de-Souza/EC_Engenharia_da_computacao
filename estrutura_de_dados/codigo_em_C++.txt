bubble sort
void bubble_sort(long arr[], long n) {
  long c, d, t;

  for (c = 0 ; c < n - 1; c++) {
    for (d = 0 ; d < n - c - 1; d++) {
      if (arr[d] > arr[d+1]) {
        t = arr[d];
        arr[d] = arr[d+1];
        arr[d+1] = t;
      }
    }
  }
}

insertion sort
void insertionSort(int arr[], int n)
{
    int i, key, j;
    for (i = 1; i < n; i++)
    {
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

selection sort
void swap(int *xp, int *yp) {
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}

void selectionSort(int arr[], int n) {
    int i, j, min_idx;

    for (i = 0; i < n-1; i++) {
        min_idx = i;
        for (j = i+1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;

        swap(&arr[min_idx], &arr[i]);
    }
}

merge sort
void merge(int *array, int l, int m, int r) {
   int i, j, k, nl, nr;
   nl = m-l+1; nr = r-m;
   int larr[nl], rarr[nr];

   for(i = 0; i<nl; i++)
      larr[i] = array[l+i];

   for(j = 0; j<nr; j++)
      rarr[j] = array[m+1+j];

   i = 0; j = 0; k = l;

   while(i < nl && j<nr) {
      if(larr[i] <= rarr[j]) {
         array[k] = larr[i];
         i++;
      } else {
         array[k] = rarr[j];
         j++;
      }
      k++;
   }
   while(i<nl) {
      array[k] = larr[i];
      i++; k++;
   }
   while(j<nr) {
      array[k] = rarr[j];
      j++; k++;
   }
}

void mergeSort(int *array, int l, int r) {
   int m;
   if(l < r) {
      int m = l+(r-l)/2;

      mergeSort(array, l, m);
      mergeSort(array, m+1, r);
      merge(array, l, m, r);
   }
}

quick sort
void swap(int* a, int* b)
{
    int t = *a;
    *a = *b;
    *b = t;
}

int partition (int arr[], int low, int high)
{
    int pivot = arr[high];
    int i = (low - 1);

    for (int j = low; j <= high- 1; j++)
    {
        if (arr[j] <= pivot)
        {
            i++;
            swap(&arr[i], &arr[j]);
        }
    }
    swap(&arr[i + 1], &arr[high]);
    return (i + 1);
}

void quickSort(int arr[], int low, int high)
{
    if (low < high)
    {
        int pivot = partition(arr, low, high);

        quickSort(arr, low, pivot - 1);
        quickSort(arr, pivot + 1, high);
    }
}

heap sort
void heapify(int arr[], int n, int i) {
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    if (left < n && arr[left] > arr[largest])
      largest = left;

    if (right < n && arr[right] > arr[largest])
      largest = right;

    if (largest != i) {
      swap(arr[i], arr[largest]);
      heapify(arr, n, largest);
    }
}

void heapSort(int arr[], int n) {
    for (int i = n / 2 - 1; i >= 0; i--)
      heapify(arr, n, i);

    for (int i = n - 1; i >= 0; i--) {
      swap(arr[0], arr[i]);
      heapify(arr, i, 0);
    }
}

gnome sort
void swap(int* a, int* b) {
    int c = *b;
    *b = *a;
    *a = c;
}

void gnomeSort(int arr[], int n) {
    int index = 0;

    while (index < n) {
        if (index == 0)
            index++;
        if (arr[index] >= arr[index - 1])
            index++;
        else {
            swap(arr[index], arr[index - 1]);
            index--;
        }
    }
}

bitonic sort
void bitonicSort(int *arr, int n) {
    int k, j, l, i, temp;
    for (k = 2; k <= n; k *= 2) {
        for (j = k/2; j > 0; j /= 2) {
            for (i = 0; i < n; i++) {
                l = i ^ j;
                if (l > i) {
                    if ( ((i&k)==0) && (arr[i] > arr[l]) || ( ( (i&k)!=0) && (arr[i] < arr[l])) )  {
                        temp = arr[i];
                        arr[i] = arr[l];
                        arr[l] = temp;
                    }
                }
            }
        }
    }
}

recursão
#include <iostream>

// Função recursiva para calcular o fatorial de um número
unsigned long long fatorial(int n) {
    if (n == 0 || n == 1) {
        return 1; // Caso base: fatorial de 0 e 1 é 1
    } else {
        // Chamada recursiva: fatorial de n é n multiplicado pelo fatorial de (n-1)
        return n * fatorial(n - 1);
    }
}

int main() {
    int numero;

    std::cout << "Digite um numero inteiro positivo: ";
    std::cin >> numero;

    // Verifica se o número é positivo
    if (numero < 0) {
        std::cout << "Numero invalido. O numero deve ser positivo." << std::endl;
        return 1;
    }

    // Calcula o fatorial e exibe o resultado
    unsigned long long resultado = fatorial(numero);
    std::cout << "O fatorial de " << numero << " é: " << resultado << std::endl;

    return 0;
}
