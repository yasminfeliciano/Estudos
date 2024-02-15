#para imprimir um item na list pode-se usar o índice do item
carros=["HRV","Golf","Argo","Focus"]
print(carros[1])
#para pegar a partir dos últimos itens, usa-se -1, -2, -3... ao invés do índice
print(carros[-1])

#para alterar um item da lista é só definir um novo item através do índice
carros=["HRV","Golf","Argo","Focus"]
carros[3]="Fusion"
print(carros)

#para adicionar itens à lista usa-se append
carros=["HRV","Golf","Argo","Focus"]
carros.append("Fit")
carros.append("Fusion")
carros.append("Polo")
print(carros)

#utiliza-se o len para saber a quantidade de itens que tem em uma lista
print(str(len(carros))+" carros na lista")

#para remover um item da lista usa-se o remove
carros.remove("Fusion")
print(carros)

#caso tente remover um item não existente o programa avisará no terminal
#carros.remove("Palio")
#print(carros)

#para remover o último item da lista usa-se o pop
carros.pop()
print(carros)

#outra forma de remover um item da lista é usando del, esse item será removido pelo índice
del carros[2]
print(carros)

#clear limpa todos os elemnetos da lista
carros.clear()
print(carros)

#pode-se copiar uma lista com o comando list
carros=["HRV","Golf","Argo","Focus"]
carros2=list(carros)
print(carros2)
print(str(len(carros2))+" carros na lista")

#pode-se juntar duas ou mais listas
carros2=["Fusca","147","Brasilia","Celta"]
carros3=carros+carros2
print(carros3)