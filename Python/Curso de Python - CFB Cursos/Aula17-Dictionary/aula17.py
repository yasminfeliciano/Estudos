#No dictionary para cada par de chaves {} existe um valor.
#Chave/Key - Valor/Value
carro={
    "Fabricante":"Honda",
    "Modelo":"HRV",
    "Ano":"2016",
    "Cor":"Prata"
    }

#Há muitas formas de se obter um objeto do dictionary, como nos exemplos abaixo.
print(carro)
print(carro["Modelo"])

fab=carro["Fabricante"]
print(fab)

fab=carro.get("Fabricante")
print(fab)

#Podemos também alterar os objetos do dictionary
carro["Cor"]="Preto"
print(carro["Cor"])

#Posso usar um loop para percorrer o dictionary
for x in carro:
    print(x) #chave
    print(carro[x]) #valor

for c,v in carro.items():
    print(c+": "+v) #(chave): (valor)

if "Modelo" in carro:
    print("SIM, Modelo é uma chave")

print("Tamanho do Dictionary: "+str(len(carro)))

#Posso adicionar uma chave.
carro["Cambio"]="Automático"
print(carro)

#Posso também remover uma chave.
carro.pop("Cambio")
print(carro)

#ou remover com del.
del carro["Ano"]
print(carro)

#Para limpar todos os elementos posso usar clear
carro.clear()
print(carro)

#Exemplo de como criar um dictionary dentro de um dictionary
carros={
    "Carro1":{
        "Fabricante":"Honda",
        "Modelo":"HRV"
    },
    "Carro2":{
        "Fabricante":"Volkswagem",
        "Modelo":"Golf"
    },
    "Carro3":{
        "Fabricante":"Ford",
        "Modelo":"Focus"
    },
}

print(carros["Carro1"]["Fabricante"])

#Ou então colocar Dictionaries dentro de um dictionary
Carro1={
        "Fabricante":"Honda",
        "Modelo":"HRV"
    }
Carro2={
        "Fabricante":"Volkswagem",
        "Modelo":"Golf"
    }
Carro3={
        "Fabricante":"Ford",
        "Modelo":"Focus"
    }

Carros={
    "C1":Carro1,
    "C2":Carro2,
    "C3":Carro3
}

print(Carros)
print(Carros["C1"]["Modelo"])