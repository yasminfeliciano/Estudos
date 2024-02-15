#para procurar uma palavra em um texto pode-se usar "in" ou "not in"
curso="Curso de Python"

res="Python" in curso
print(res)

res="Python" not in curso
print(res)


#Para encontrar a palavra sem distinção de maiúscula ou minúscula basta usar o comando upper() ou lower() para igualar as letras
texto="Curso de Python"
palavra="python"

res=palavra in texto
print(res)

res=palavra.upper() in texto.upper()
print(res)

#é possível concatenar duas variáveis
curso="Curso de Python"
canal="CFB Cursos"

res=curso+" do canal "+canal
print(res)

#concatenar vários tipos de variáveis diferentes
cidade="Belo Horizonte"
dia=15
mes="Dezembro"
ano=2019
print(cidade+", "+str(dia)+" de "+mes+" de "+str(ano)) 

#utilizar uma variável de retorno com placeholder
data="{}, {} de {} de {}\n\"{}\""
print(data.format(cidade,dia,mes,ano,canal))

#Caracters de escape \'-aspas \"-aspas duplas \n-quebra de linha \r-retorno \t-tabulação \b-backspace