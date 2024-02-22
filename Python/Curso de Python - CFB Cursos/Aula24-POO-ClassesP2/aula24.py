class Carro:
    velMax=0
    ligado=False
    cor=""
    def __init__(self,v,l,c):
        self.velMax=v
        self.ligado=l
        self.cor=c
    def mostrar(self):
        print("Velocidade Maxima: " +str(self.velMax))
        print("Cor..............: "+self.cor)
        estado="sim" if self.ligado else "não"
        print("Ligado...........: "+estado)
        print("--------------------------------------")
    def ligar(self):
        self.ligado=True
    def desligar(self):
        self.ligado=False
    def andar(self):
        if(self.ligado):
            print("Andando")
        else:
            print("Carro desligado")

c1=Carro(200,False,"Preto")
c2=Carro(120,False,"Branco")
c3=Carro(350,False,"Vermelho")

c1.ligar()
c2.ligar()

c1.mostrar()
c2.mostrar()
c3.mostrar()

c2.andar()