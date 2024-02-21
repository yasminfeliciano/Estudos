def curso():
    print("Curso de Python - CFB Cursos")
    print("youtube.com/cfbcursos\n")

curso() #Chamando a função somar()
curso() 
curso()

n1=10
n2=5
def somar():
    r=n1+n2
    print("Soma de "+str(n1)+" e "+str(n2)+" = "+str(r))

somar()

def subtrair():
    r=n1-n2
    print("Subtração de "+str(n1)+" e "+str(n2)+" = "+str(r))

subtrair()

def multiplicar():
    r=n1*n2
    print("Multiplicação de "+str(n1)+" e "+str(n2)+" = "+str(r))

multiplicar()

def dividir():
    r=n1/n2
    print("Divisão de "+str(n1)+" e "+str(n2)+" = "+str(r))

dividir()

#Fazendo uma função para chamar outras funções
def calculos():
    somar()
    subtrair()
    multiplicar()
    dividir()

calculos()