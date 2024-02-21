#Posde-se definir vários parâmetros para uma função
def somar(n1,n2,n3,n4):
    r=n1+n2+n3+n4
    print("Soma = "+str(r))

somar(5,7,3,2)
somar(12,8,1,20)
somar(1,2,0,0)

#Pode-se exibir apenas alguns parâmetros da função
def textos(*t):
    print(t[0])
    print(t[1])
    print(t[2])

textos("CFB Cursos","Python","Canal","Curso","Computador")

#Pode-se percorrer todos os parâtros de uma função
def textos(*txt):
    for t in txt:
        print(t)

textos("CFB Cursos","Python","Canal","Curso","Computador")

def somar(*num):
    r=0
    for n in num:
         r+=n
    print("Soma = "+str(r))

somar(5,2,3,5,20,15,0,1,37)

#Também posso passar um valor padrão para o argumento
def carros(c="Golf"):   #Nesse caso Golf é o valor padrão
    print("Modelo: "+c)

carros("HRV")
#O valor padrão é o valor que será utilizado quando não houver entradas
carros()

#Posso passar valores de uma lista também
valores=[1,5,3,2]
def somar(num):
    r=0
    for n in num:
        r+=n
    print("Soma = "+str(r))

somar(valores)