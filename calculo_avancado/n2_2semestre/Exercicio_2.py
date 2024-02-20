#Importação das bibliotecas de interesse:
import numpy as np
import math
import matplotlib.pyplot as plt
from scipy import signal

def funcao_gera_figura(f,s,t,nome):
    #Entradas:
    #f [numpy array] : função periódica que estamos interessados 
    #em analisar
    #s [numpy array]: expansão em Série de Fourier da função f, pre-
    #viamente calculada
    #t [numpy array]: vetor de tempo
    #nome [string]: nome do arquivo a ser salvo.
    #Importação das bibliotecas de interesse:
    
    #Resolução da figura:
    dpi = 300
    #Criação da figura, com tamanho e resolução especificados
    fig, ax = plt.subplots()
    fig.set_size_inches(5, 3)
    fig.set_dpi(dpi)
    
    #Gera os gráficos da função de interesse e da sua aproximação
    #por Série de Fourier:
    plt.plot(t,f,'-b')
    plt.plot(t,s,'-r')
    #Definição dos eixos
    ax.axis([min(t), max(t), -1.5, 1.5])
    #Gera a grade para facilitar a leitura do gráfico
    ax.grid()
    #Nomes de cada eixo:
    plt.xlabel(r'$t[s]$')
    #Salva a imagem em formato jpg.
    plt.tight_layout()
    plt.savefig(nome+'.jpg', format='jpg', dpi=dpi)

def coeficientes_fourier(numero_de_harmonicas):
    #Entrada:
    #numero_de_harmonicas [int]: numero de harmônicas a serem consi-
    #deradas
    #Saída:
    #b_n [numpy array]: vetor de coeficientes b_n (n entre 1 e 
    #numero_de_harmonicas) da expansão em Série de Fourier
    # Inicialização do vetor b_n (para n >= 1):
    b_n = np.zeros(numero_de_harmonicas)
    # Criação de um vetor com os números n de cada harmônica, indo de 1 até o 
    # número de harmônicas fornecido como entrada da função:
    n = np.arange(1, numero_de_harmonicas+1)
    #Para cada n indo de 1 até o número de harmonicas:
    for i in range(numero_de_harmonicas):
        #Calcula o coeficiente b_n de acordo com a fórmula simplificada:
        bn = (2/T0) * np.trapz(f * np.sin(2*np.pi*n[i]*t/T0), t) / T0
        b_n[i] = bn
    return b_n

    # Ajusta os valores dos coeficientes para que as linhas azul e vermelha sejam iguais
       #b_n = np.where(n % 2 != 0, b_n, 0)
        
       
        #if n[i] % 2 != 0:
           # b_n = b_n
        #else:
         #   b_n = 0
   
    

#########################################################################
# Script principal:
t = np.linspace(-2, 2, 10000) 


T0 = 2


f0 = 1/T0

f = signal.square(2*np.pi*f0*t)
dpi = 300
#Criação da figura, com tamanho e resolução especificados
fig, ax = plt.subplots()
fig.set_size_inches(5, 3)
fig.set_dpi(dpi)

#Gera os gráficos da função de interesse e da sua aproximação
#por Série de Fourier:
plt.plot(t,f,'-b')
#Definição dos eixos
ax.axis([min(t), max(t), -1.5, 1.5])
#Gera a grade para facilitar a leitura do gráfico
ax.grid()
#Nomes de cada eixo:
plt.xlabel(r'$x$')
plt.ylabel(r'$f(x)$')
plt.tight_layout()
#Salva a imagem em formato jpg.
plt.savefig('Exercicio2.jpg', format='jpg', dpi=dpi)

vetor_harmonicas = [1,3,5,7,9,11,13,25,50]

for N in vetor_harmonicas:    
    bn = coeficientes_fourier(N)
    s = np.zeros(len(t))
    for n in range(N):
        s+= bn[n]*np.sin(2*np.pi*(n+1)*t/T0)
    nome_figura = "exercicio_2_"+str(N)+"_harmonicas"
    funcao_gera_figura(f,s,t,nome_figura)

