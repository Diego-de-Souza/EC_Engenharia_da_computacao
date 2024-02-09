#include <iostream>
#include <stdlib.h>
#include <istream>


using namespace std;
using std::cout;
using std::endl;


int main(int argc, char *argv[])
{
    string s1, s2;
    
  int i,j;
  cout << "Ola'!" << endl;
  getline(cin, s1); 
  cout << "String lida 1:" << s1 << "*" << endl;
  getline(cin, s2); 
  cout << "String lida 2:" << s2 << "*" << endl;

  getline(cin, s1, '&'); // para a leitura no '&'
  // note que o caracter '&' NÃO vai para 's1'
  cout << "String lida 1:" << s1 << "*" << endl;

  system("PAUSE");	
  return 0;
}


