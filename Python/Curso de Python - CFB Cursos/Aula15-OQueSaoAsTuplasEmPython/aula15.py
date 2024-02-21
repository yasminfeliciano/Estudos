l_carros=["HRV","Golf","Argo"]
t_carros=("HRV","Golf","Argo")

#Na lista é possível substituir, acrescentar e deletar itens
l_carros[2]="Focus"
for x in l_carros:
    print(x)

#Na tupla não é possível substituir, acrescentar ou deletar itens
"""
t_carros[2]="Focus"
for x in t_carros:
    print(x)
"""

#Para fazer alterações na tupla, primeiro é necessário transformá-la em uma lista.
t_carros=("HRV","Golf","Argo")
l_carros=list(t_carros)
l_carros[2]="Focus"
t_carros=tuple(l_carros)

for x in t_carros:
    print(x)