import os

os.system('cls') #windows
#os.system('clear') #Linux

print("Curso de Python")

#O comando input fica esperando algo ser digitado no terminal.
nome=input("Digite seu nome: ")
print("Nome digitado: "+nome)

#Tudo o que retorna do input é uma string, por isso os valores não são somados e sim concatenados.
num1=input("Digite o primeiro valor(concat)..: ")
num2=input("Digite o segundo valor(concat)...: ")
res=num1+num2
print("Soma dos valores: "+res)

#Para a soma dos resultados é necessário converter as variáveis para as unidades requisitadas.
num1=int(input("Digite o primeiro valor(soma)..: "))
num2=int(input("Digite o segundo valor(soma)...: "))
res=num1+num2
print("Soma dos valores: "+str(res))
