#imprime o valor da variável
aula=True
print(aula)

#imprime um boolean de acordo com a expressão
aula=10<15
print(aula)

aula=10>15
print(aula)

#imprime True se houver conteúdo dentro da variável e False se estiver vazio
aula="CFB Cursos"
print(bool(aula))

aula=""
print(bool(aula))

#utilizando o comando if
if aula:
    print("Possui texto")
else:
    print("Vazio")

#variáveis inteiras valendo 0 é false, qualquer valor diferente de 0 é True
aula=0
print(bool(aula))

aula=105
print(bool(aula))

#a mesma coisa acontece com dictionaries, sets, tuplas lists, se estiver vazio é False