// atividade_aula2.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>

using namespace std;

void insertion(int arranjo[], int tamanho) {
    for (int i = 1; i < tamanho; i++) {
        int chave = arranjo[i];
        int j = i - 1;

        // Move os elementos maiores para a direita
        while (j >= 0 && arranjo[j] > chave) {
            arranjo[j + 1] = arranjo[j];
            j--;
        }

        // Insere o elemento na posição correta
        arranjo[j + 1] = chave;
        // Imprime a lista após cada iteração
        cout << "Iteracao " << i << ": ";
        for (int k = 0; k < tamanho; k++) {
            cout << arranjo[k] << " ";
        }
        cout << endl;
    }
}

int main() {
    int tamanhoArray[] = { 7, 3, 2, 1, 5 };
    int tamanho = sizeof(tamanhoArray) / sizeof(tamanhoArray[0]);

    // Chama a função insertion para ordenar o array
    insertion(tamanhoArray, tamanho);

    // Imprime o array ordenado
    cout << "Array ordenado: ";
    for (int i = 0; i < tamanho; i++) {
        cout << tamanhoArray[i] << " ";
    }
    cout << endl;

    return 0;
}

// Executar programa: Ctrl + F5 ou Menu Depurar > Iniciar Sem Depuração
// Depurar programa: F5 ou menu Depurar > Iniciar Depuração

// Dicas para Começar: 
//   1. Use a janela do Gerenciador de Soluções para adicionar/gerenciar arquivos
//   2. Use a janela do Team Explorer para conectar-se ao controle do código-fonte
//   3. Use a janela de Saída para ver mensagens de saída do build e outras mensagens
//   4. Use a janela Lista de Erros para exibir erros
//   5. Ir Para o Projeto > Adicionar Novo Item para criar novos arquivos de código, ou Projeto > Adicionar Item Existente para adicionar arquivos de código existentes ao projeto
//   6. No futuro, para abrir este projeto novamente, vá para Arquivo > Abrir > Projeto e selecione o arquivo. sln
