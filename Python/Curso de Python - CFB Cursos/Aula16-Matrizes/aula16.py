carros=["HRV","Golf","Focus","Argo"] #array/list

print(carros[1])
carros[2]="Fusion"

for x in carros:
    print(x)

#Uma Matriz é um array com outros array dentro
carros=[
    ["Modelo","HRV"],
    ["Fabricante","Honda"],
    ["Ano",2016]
    ]

carros.append(["Cor","Prata"])
carros[2][1]=2019
print(carros[2][1])

for l,c in carros:
    print("L: "+l+" | C: "+str(c))
