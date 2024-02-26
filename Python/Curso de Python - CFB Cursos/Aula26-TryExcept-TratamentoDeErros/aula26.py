#Para tratamento de erro do try except não é necessário todos os passos, mas pelo menos try e except são necessários
x=4
try:
    print(x)
except NameError:
    print("X nao definido")
except:
    print("Erro desconhecido")
else:
    print("Tudo certo")
finally:
    print("Fim do tratamento")

#Nesse caso o raise Exception para a execução do programa
num=0

if num <1:
    raise Exception("Valor não permitido")

#Outro exemplo
num="Ok"

if not type(num) is int:
    raise Exception("Somente numeros sao permitidos")
else:
    print(str(num))