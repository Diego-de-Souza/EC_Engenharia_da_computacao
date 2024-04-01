#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include "Pessoa.h"

using namespace std;

int main() {
    std::vector<Pessoa> pessoas; // Usaremos um vetor dinâmico em vez de um array estático
    int tamanho = 0;

    ifstream arquivoEntrada("dados_pessoais.csv");
    if (!arquivoEntrada.is_open()) {
        cerr << "Erro ao abrir o arquivo!" << endl;
        return 1;
    }

    //ignorando a primeira linha
    std::string cabecalho;
    std::getline(arquivoEntrada, cabecalho);

    // Ler o restante das linhas
    std::string linha;
    while (std::getline(arquivoEntrada, linha)) {
        std::stringstream ss(linha);
        std::string nome, idadeStr, pesoStr, alturaStr;
        std::getline(ss, nome, ';');
        std::getline(ss, idadeStr, ';');
        std::getline(ss, pesoStr, ';');
        std::getline(ss, alturaStr, ';');
    
        // Converter os valores para os tipos apropriados
        float peso = std::stof(pesoStr);
        float altura = std::stof(alturaStr);

        // Criar um objeto Pessoa com os dados da linha e adicionar ao vetor
        Pessoa pessoa(nome, idadeStr, peso, altura);
        pessoas.push_back(pessoa);
        
    }

    for (const auto& pessoa : pessoas) {
        std::cout << "Nome: " << pessoa.getNome() << std::endl;
        std::cout << "Idade: " << pessoa.imprimeIdade() << std::endl;
        std::cout << "Peso: " << pessoa.getPeso() << std::endl;
        std::cout << "Altura: " << pessoa.getAltura() << std::endl;
        std::cout << std::endl; // Para separar os dados de cada pessoa
    }
    /*
    string linha;
    bool primeiraLinha = true;
    while (getline(arquivoEntrada, linha)) {
        if (primeiraLinha) {
            primeiraLinha = false;
            continue;
        }
        istringstream ss(linha);
        string token;

        getline(ss, token, ';');
        getline(ss, token, ';');

    }
    */
    return 0;
}
