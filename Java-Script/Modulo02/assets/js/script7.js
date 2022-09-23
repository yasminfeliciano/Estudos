let nome ='Bonieky';
let nomes = ['bonieky', 'pedro'];

let personagem = {
    nome: 'Bonieky',
    idade: 90,
    pais: 'Brasil',
    olhos: ['preto', 'azul'],
    caracteristicas: {
        forca: 20,
        magia: 5,
        stamina: 15,
    }
}

//Se for requisitado algum item ou variável da array, essa variável será exibida sozinha. 
console.log(personagem.nome);

//Porém, se não for requisitado nenhum item ou variável específica da array, ela vem completa, ou seja, com todos os itens.
console.log(personagem);

console.log(`${personagem.nome} tem ${personagem.idade} anos.`);

//Também é possível acessar um item de um objeto que está dentro de um array utilizando o modo de cascata.
console.log(personagem.caracteristicas.magia);

//Posso também acessar um item de um array dentro de outro array
console.log(personagem.olhos[1]);



//Da mesma forma que eu posso alterar o valor de uma variável simples, eu também posso alterar uma variável de um objeto dentr de uma array
personagem.nome = 'Pedro';
console.log(personagem.nome);

personagem.caracteristicas.forca +=5;
console.log(personagem.caracteristicas.forca);

personagem.olhos.push('verde');
console.log(personagem.olhos);



let personagem2 = {
    nome:'Victor',
    idade: 34,
    carros: [
        {modelo: 'Fiat', cor: 'preto'},
        {modelo: 'Ferrari', cor: 'vermelho'}
    ]
}

// personagem é uma variável, carros é um array e modelo é um objeto
console.log(personagem2.carros[1].modelo);