import pandas as pd
import numpy as np
import json

def resultado(obj):
  maior = 0
  soma = 0
  menor = float(obj[1]['valor'])
  for i in range(30):
    soma = soma +  float(obj[i]['valor'])
    if(float(obj[i]['valor']) > maior):
      maior = float(obj[i]['valor'])
      a = i
    if(float(obj[i]['valor']) <= menor):
      menor = float(obj[i]['valor'])
      b = i
    if(i == 29):
      print('O dia de maior faturamento foi %i com valor de %.3f reais'% (obj[a]['dia'],obj[a]['valor']))
      print('O dia de menor faturamento foi %i com valor de %.3f reais'% (obj[b]['dia'],obj[b]['valor']))
  c = 0
  media = soma/30.0
  for j in range(30):
    if (float(obj[j]['valor']) > media):
      c+= 1
  print('%i foi o número de dias com o faturamento maior do que a média = %.3f'% (c, media))

with open('dados.json', 'r') as arq:
  obj = json.load(arq)
  resultado(obj)
