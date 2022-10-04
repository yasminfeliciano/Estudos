let pessoa ={
    nome: 'Bonieky',
    sobrenome: 'Lacerda',
    idade:90,
    nomeCompleto: function(){
        return this.nome + ' ' + this.sobrenome;
        //Ou pode concatenar assim também
        //return `${this.nome} ${this.sobrenome}`
    }
}

console.log( pessoa.nomeCompleto() );



//Loopings
for(let n = 0; n<=10;n++){
    console.log('Frase Qualquer' + n);
}



//Abaixo temos 3 formas de fazer com que o looping gere o mesmo resultado. 
let cores = ['preto', 'branco', 'azul', 'vermelho'];

//Esse lopping vai fazer uma lista de cores de acordo com a quantidade de cores que tem dentro do array.
for(let n = 0; n < cores.length; n++){
    console.log(cores[n]);
}

//Esse looping é muito parecido com o de cima, porém ele vai criar a variável 'i' a cada vez que executar o looping.
for(let i in cores){
    console.log(cores[i]);
}

//Esse looping vai pegar o valor da cor.
for(let cor of cores){
    console.log(cor);
}



let cores2 = [
    {nome: 'preto', qt: 10},
    {nome: 'azul', qt: 15},
    {nome: 'vermelho', qt: 15},
]

//O looping abaixo vai fazer todas as letras ficarem maiúsculas.
for(let i in cores2){
    cores2[i].nome = cores2[i].nome.toUpperCase();
}

//O looping abaixo vai me dar informações da cor de cada objeto
for(let cor of cores2){
    console.log(`Nome: ${cor.nome} - ${cor.qt}`);
}