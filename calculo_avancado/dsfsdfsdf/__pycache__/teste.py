# -*- coding: utf-8 -*-
"""
Created on Tue Sep 12 13:44:19 2023

@author: lucas
"""
from funcao_Bolzano_dicotomia import funcao_Bolzano_dicotomia

F,K = funcao_Bolzano_dicotomia(-10,-13, 1e-5)

print(f" Foram {K} interações")
print(f" A raiz é: {F}")