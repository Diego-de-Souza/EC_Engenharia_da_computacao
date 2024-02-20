def metodo_newton_raphson(x0, num_iter):
    #Entradas:
        #x0: estimativa inicial do método de Newton-Raphson
        #num_iter: número de iterações a ser realizada
    
    
    #Importação das funções no arquivo "funcoes.py":
    from funcoes import funcao_f
    from funcoes import funcao_f_linha
    #Inicializando a estimativa da raiz como x0:
    estimativa = x0
    
    #A variável k conta o número de iterações realizadas até o momento:
    k = 0
    
    
    while k < num_iter:
        #Cálculo do valor da função f para a estimativa atual:
        f = funcao_f(estimativa)
        #A partir daqui, vocês devem completar....
        fL = funcao_f_linha(estimativa)
        
        x1 = estimativa - (f/fL)
        
        k += 1
        estimativa = x1
        
    return estimativa
