import os
os.system('cls') #limpar a tela

#Como funciona a função while

"""Inicialização de variável de controle
while (teste lógico)
    comando 1
    comando 2
    comando x
    incremento ou decremento de controle
"""
#uso simples do loop while
i=0
while i<10:
    print(i)
    i+=1
print("Fim do loop")

#uso do break, para o loop antes da condição inicial
i=0
while i<10:
    print(i)
    i+=1
    if(i>=5):
        break
print("Fim do loop")

#Percorrendo coleções com loop while
carros=["HRV","Golf","Argo","Onix","Focus"]
i=0
tam=len(carros)
while i<tam:
    print(carros[i])
    i+=1
print("\nFim do loop")

#Criando Coleções com loop While
carros=[]
carro=input("Digite o nome do novo carro: ")
while carro != "-1":
    carros.append(carro)
    carro=input("Digite o nome do novo carro: ")

os.system('cls')
for x in carros:
    print(x)
