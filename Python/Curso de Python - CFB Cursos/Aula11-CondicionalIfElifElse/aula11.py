a=10
b=5
res=0
op="/"
if op=="+":
    res=a+b
elif op=="-":
    res=a-b
elif op=="*":
    res=a*b
elif op=="/":
    res=a/b
else:
    print("Operador inválido")
print(str(a)+op+str(b)+" = "+str(res))

clima="sol"
dinheiro=500
lugar=""
if clima=="sol" and (dinheiro>=300 and dinheiro<=500):
    lugar="clube"
else:
    lugar="cinema"
print("Vou ao "+lugar)

clima="sol"
dinheiro=500
lugar=""
if clima=="sol" or (dinheiro>=300 and dinheiro<=500):
    lugar="clube"
else:
    lugar="cinema"
print("Vou ao "+lugar)

#   AND - Todas as condições devem ser verdadeiras para que seja verdadeiro
#   V   V   =   V
#   V   F   =   F
#   F   V   =   F
#   F   F   =   F

#   OR - Basta que apenas uma condição seja verdadeira para que seja verdadeiro
#   V   V   =   V
#   V   F   =   V
#   F   V   =   V
#   F   F   =   F