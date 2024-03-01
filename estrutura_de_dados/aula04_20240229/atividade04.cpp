#include <iostream>
#include <string>
#include <libxl/libxl.h>

class Pessoa {
private:
    std::string nome;
    double peso;
    int idade;
    double altura;

public:
    // Construtor da classe Pessoa
    Pessoa(std::string nome, double peso, int idade, double altura) {
        this->nome = nome;
        this->peso = peso;
        this->idade = idade;
        this->altura = altura;
    }

    // Métodos para acessar e modificar os atributos da classe
    std::string getNome() const {
        return nome;
    }

    void setNome(const std::string& novoNome) {
        nome = novoNome;
    }

    double getPeso() const {
        return peso;
    }

    void setPeso(double novoPeso) {
        peso = novoPeso;
    }

    int getIdade() const {
        return idade;
    }

    void setIdade(int novaIdade) {
        idade = novaIdade;
    }

    double getAltura() const {
        return altura;
    }

    void setAltura(double novaAltura) {
        altura = novaAltura;
    }
};

int main() {
    
    libxl::Book* book = xlCreateXMLBook(); // Cria um objeto Book
    if (book) {
        if (book->load("Z:\EC_Engenharia_da_computacao\estrutura_de_dados")) { // Abre o arquivo Excel
            libxl::Sheet* sheet = book->getSheet(0); // Obtém a primeira planilha
            if (sheet) {
                // Lê os dados da célula a2,b2, c2, d2
                std::cout << "Valor da célula B2: " << sheet->readNum(0, 1) << std::endl;
                std::cout << "Valor da célula B2: " << sheet->readNum(1, 1) << std::endl;
                std::cout << "Valor da célula B2: " << sheet->readNum(2, 1) << std::endl;
                std::cout << "Valor da célula B2: " << sheet->readNum(3, 1) << std::endl;
            } else {
                std::cerr << "Erro: Não foi possível obter a planilha." << std::endl;
            }
        } else {
            std::cerr << "Erro: Não foi possível carregar o arquivo Excel." << std::endl;
        }
        book->release(); // Libera a memória alocada
    } else {
        std::cerr << "Erro: Não foi possível criar o objeto Book." << std::endl;
    }
    
    // Imprimindo os atributos da pessoa1
    std::cout << "Nome: " << pessoa1.getNome() << std::endl;
    std::cout << "Peso: " << pessoa1.getPeso() << std::endl;
    std::cout << "Idade: " << pessoa1.getIdade() << std::endl;
    std::cout << "Altura: " << pessoa1.getAltura() << std::endl;


    return 0;
}
