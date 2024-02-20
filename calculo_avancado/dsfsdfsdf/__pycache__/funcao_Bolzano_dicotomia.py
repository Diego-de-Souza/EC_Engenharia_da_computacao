# -*- coding: utf-8 -*-
"""
Created on Tue Sep 12 13:14:09 2023

@author: lucas
"""

import math as M
from funcao import funcao 

def funcao_Bolzano_dicotomia(A0, B0, precisao):
    #solução de f(x) = e^x + x
    
    if funcao(A0) * funcao(B0) > 0:
        print ("Fora do intervalo")
        return ['Não encontrado',0]
    
    else:
        k = round( (M.log2(B0 - A0) - M.log2(precisao) - 1) + 0.5) 
        
        f=0
        
        for i in range(k):
    
        
            
            f = (B0 + A0) / 2
            
            temp = funcao(f)
            
            if temp > 0:
                B0 = f
            
            elif temp < 0:
                A0 = f
                
                
        
        return [f,k]
    
    
    
    