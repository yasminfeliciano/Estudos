valores=[1,5,3,2,10,4,8]
def somar(num):
    r=0
    for n in num:
        r+=n
    return r

def valLista(num):
    for v in num:
        print(v)

valLista(valores)
print(str(valores)+": soma = "+ str(somar(valores)))