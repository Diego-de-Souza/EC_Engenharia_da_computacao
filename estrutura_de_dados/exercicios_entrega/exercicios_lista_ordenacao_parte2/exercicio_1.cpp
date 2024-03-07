#include <iostream>
#include <vector>

using namespace std;

// Definição da classe Evento
class Evento {
public:
    string nome;
    int dia, mes, ano, hora, minuto, segundo;

    Evento(string nome, int dia, int mes, int ano, int hora, int minuto, int segundo) {
        this->nome = nome;
        this->dia = dia;
        this->mes = mes;
        this->ano = ano;
        this->hora = hora;
        this->minuto = minuto;
        this->segundo = segundo;
    }
};

// Função para imprimir um evento
void imprimirEvento(const Evento& evento) {
    cout << evento.nome << " - " << evento.dia << "/" << evento.mes << "/" << evento.ano << " " 
         << evento.hora << ":" << evento.minuto << ":" << evento.segundo << endl;
}

// Função para ordenar os eventos por ordem cronológica usando o algoritmo Insertion Sort
void ordenarEventos(vector<Evento>& eventos) {
    int n = eventos.size();
    for (int i = 1; i < n; ++i) {
        Evento chave = eventos[i];
        int j = i - 1;
        
        // Move os elementos do vetor que são maiores que a chave para uma posição à frente de sua posição atual
        while (j >= 0 && (eventos[j].ano > chave.ano ||
                          (eventos[j].ano == chave.ano && eventos[j].mes > chave.mes) ||
                          (eventos[j].ano == chave.ano && eventos[j].mes == chave.mes && eventos[j].dia > chave.dia) ||
                          (eventos[j].ano == chave.ano && eventos[j].mes == chave.mes && eventos[j].dia == chave.dia && eventos[j].hora > chave.hora) ||
                          (eventos[j].ano == chave.ano && eventos[j].mes == chave.mes && eventos[j].dia == chave.dia && eventos[j].hora == chave.hora && eventos[j].minuto > chave.minuto) ||
                          (eventos[j].ano == chave.ano && eventos[j].mes == chave.mes && eventos[j].dia == chave.dia && eventos[j].hora == chave.hora && eventos[j].minuto == chave.minuto && eventos[j].segundo > chave.segundo))) {
            eventos[j + 1] = eventos[j];
            j = j - 1;
        }
        eventos[j + 1] = chave;
    }
}

int main() {
    // Criando uma lista de eventos de exemplo
    vector<Evento> eventos = {
        Evento("Evento 1", 6, 3, 2024, 10, 0, 0),
        Evento("Evento 2", 6, 3, 2024, 8, 0, 0),
        Evento("Evento 3", 6, 3, 2024, 12, 0, 0),
        Evento("Evento 4", 6, 3, 2024, 9, 0, 0),
        Evento("Evento 5", 6, 3, 2024, 11, 0, 0)
    };

    // Ordenando os eventos por ordem cronológica
    ordenarEventos(eventos);

    // Imprimindo os eventos ordenados
    cout << "Eventos ordenados por ordem cronológica:" << endl;
    for (const auto& evento : eventos) {
        imprimirEvento(evento);
    }

    return 0;
}
