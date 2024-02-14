num1=num2=res=0

#ESCOPO DE VARIÁVEIS
#VARIÁVEIS GLOBAIS
"""Aqui temos um exemplo de variável global, pois ela abrange todo o código."""
canal="CFB Cursos"

def cn():
    print(canal)
cn()

#VARIÁVEIS LOCAIS
"""Aqui temos um exemplo de variável local, pois ela abrange apenas o conteúdo da função."""
def cn():
    canal2="CFB Cursos"

"""print(canal2) Esse comando não é executado, pois a variável não existe fora da função."""

#VARIÁVEIS GLOBAIS DEFINIDAS NA FUNÇÃO
"""Eu só consigo acessar essa variável fora da função se eu definir a mesma como global dentro da função"""
def cn():
    global canal3
    canal3="CFB Cursos"

print(canal3)