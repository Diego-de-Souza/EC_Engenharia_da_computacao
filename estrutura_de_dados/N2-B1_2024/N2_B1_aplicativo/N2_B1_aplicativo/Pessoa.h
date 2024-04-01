#pragma once
#include <iostream>
#include <string>

class Pessoa
{
private:
	std::string nome;
	int idade;
	float peso;
	float altura;
	int tamanho;
	int capacidade;

	//calcula a didade com base na data de nascimento
	int calculaIdade(std::string dataNasc);
public:
	//construtor padrao
	Pessoa();
	//construtor com a quantidade de pessoas no vetor
	Pessoa(std::string nome, std::string idade, float peso, float altura);

	//destrutor para liberar a memoria alocada para o  vetor
	~Pessoa();

	// Método para obter o nome da pessoa
	std::string getNome() const;
	//imprime idade
	int imprimeIdade() const;

	//teste
	std::string testeImpressao();
	//buscar nome
	std::string getNome();
	//busca peso
	float getPeso() const;
	//busca altura
	float getAltura() const;
};

