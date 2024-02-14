x=1 #int
print(x)

x=1 #int
print("Tipo: "+str(type(x))) #type

x="CFB Cursos" #string
print("Valor: "+str(x))

x=15.6 #float
print(x)

x=False #bool
print(x)

n1=5;n2=2;x=complex(n1,n2) #complex
print(x.real)
print(x.imag)

x=complex(1j) #complex
print(x.real)
print(x.imag)

x=["Carro", "Aviao", "Navio", 1, 58.3, True] #list/array
x[0]="Onibus"
print("Valor: "+x[0])

x=("Carro", "Aviao", "Navio", 1, 58.3, True) #tupla
#x[0]="Bicicleta" #Não é posssível alterar a tupla
print("Valor: "+x[0])

x=range(0,100,1) #range cria uma lista (inicio, quantos item tem, de quantos em quantos nnúmeros)
print("Valor: "+str(x[0]))

x={         #dictionary
    "canal":"CFB Cursos",
    "curso":"Curso de Python",
    "nome":"Bruno"
}
print("Valor: "+x["nome"])

x={5,7,4,5,7,4,8} #set
print("Valor: "+str(x))

x=frozenset({5,7,4,5,7,4,8}) #frozenset não pode ser alterado
print("Valor: "+str(x))