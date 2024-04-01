#include "Pessoa.h"
#include <string>
#include <sstream>
#include <chrono>


Pessoa::Pessoa(){
}

Pessoa::Pessoa(std::string nome, std::string idade, float peso, float altura) {
	this->nome = nome;
	this->idade = calculaIdade(idade);
	this->peso = peso;
	this->altura = altura;
}

Pessoa::~Pessoa() {}

std::string Pessoa::getNome() const {
	return nome;
}

int Pessoa::calculaIdade(std::string dataNasc) {
    std::istringstream ss(dataNasc);
    int dia, mes, ano;
    char separador;
    ss >> dia >> separador >> mes >> separador >> ano;

    // Substitua localtime por localtime_s
    std::tm hojeLocal;
    time_t tempoHoje = std::time(nullptr);
    localtime_s(&hojeLocal, &tempoHoje);

    int idade = hojeLocal.tm_year + 1900 - ano;
    if (mes > hojeLocal.tm_mon + 1 || (mes == hojeLocal.tm_mon + 1 && dia > hojeLocal.tm_mday)) {
        idade--;
    }
    return idade;
}

int Pessoa::imprimeIdade() const {
	return this->idade;
}

std::string Pessoa::getNome() {
    return  this->nome;
}

float Pessoa::getPeso() const{
    return this->peso;
}

float Pessoa::getAltura() const{
    return this->altura;
}
