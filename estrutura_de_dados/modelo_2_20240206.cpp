#include <iostream>

using namespace std;

int main()
{
  const int TAM = 80;
  char guarda[TAM];
  cout << "Digite uma frase com espaços: " << endl;
  cin.getline(guarda, TAM);
  cout << "A frase digitada é: \n" << guarda << endl;
  return 0;
}
