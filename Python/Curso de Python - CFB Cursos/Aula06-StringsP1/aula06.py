curso=" Curso de Python" 

print(curso[10]) #seleciona um caracter
print(curso[10:16]) #seleciona um conjuunto de caracters consecutivos
print("Tamanho: " + str(len(curso))) #len conta os caracters
print(curso.strip()) #strip remove espaços do início e do fim de uma string
print(curso.lower()) #lower deixa tudo em letra minúscula
print(curso.upper()) #upper deixa tudo em letra maiúscula
print(curso.lower().strip()) #é possível utilizar mais de um comando na mesma sentença
print(curso.replace("Python","C#")) #replace troca um termo pelo outro
print(curso.split(" ")) #split remove os espaços

curso="Curso de Python"
a=curso.split(" ") #split pode ser usado para criar uma lista de palavras entendendo o espaço como separação entre elas
print(a[0])
print(a[2])