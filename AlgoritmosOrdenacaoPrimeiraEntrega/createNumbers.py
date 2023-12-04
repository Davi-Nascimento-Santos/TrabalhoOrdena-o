import csv
from random import randint

# Lista de números de 0 a 199999
numeros = list()
for i in range(199999, -1, -1):
    numeros.append(i)

# Nome do arquivo CSV
nome_arquivo = 'numerosDecrescente.csv'

# Escrever os números no arquivo CSV
with open(nome_arquivo, 'w', newline='') as csvfile:
    writer = csv.writer(csvfile)
    
    # Escrever o cabeçalho, se necessário
    # writer.writerow(['Numero'])  # Descomente esta linha se quiser um cabeçalho
    
    # Escrever os números na coluna
    for numero in numeros:
        writer.writerow([numero])

print(f'O arquivo CSV {nome_arquivo} foi criado com sucesso.')
