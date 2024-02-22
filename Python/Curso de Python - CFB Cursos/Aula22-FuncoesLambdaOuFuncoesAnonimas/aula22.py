#Funções lambda são anônimas, portanto não é necessário colocar um nome para a função
#Sintaxe da função lambda -> lambda arg:expres
soma=lambda a,b:a+b

#Posso exibir o resultado na tela associando lambda a uma variável.
r=soma(2,5)
print(r)

#Ou posso exibir passando a função diretamente.
print(soma(2,5))

#Outros exemplos.
soma=lambda a,b:a+b
mult=lambda a,b,c:(a+b)*c
print(soma(2,5))
print(mult(2,5,3))

#Passando a função diretamente no print
print((lambda a,b:a+b)(3,2))

r=lambda x, func:x+func(x)
res=r(2,lambda x:x*x)
print(res)
res=r(2,lambda x:x+x)
print(res)