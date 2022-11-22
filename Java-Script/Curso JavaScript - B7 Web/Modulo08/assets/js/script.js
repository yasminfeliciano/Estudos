//JSON
//JSON é um objeto Javascript onde é possível armazenar infinitas informações.
let pessoa = {
    nome: 'Bonieky',
    idade:90,
    //Array dentro do objeto
    caracteristicas: ['sorridente', 'maravilhoso', 'top'],
    //Objeto dentro do objeto
    estetica: {
        altura: 190,
        peso: 90
    }
};

console.log(pessoa.nome);

console.log(pessoa.idade);

console.log(pessoa.caracteristicas[1]);

console.log(pessoa.estetica.peso);



//JSON.parse
//Quando uma requisição é feita o usuário recebe um JSON puro, ou seja, uma string que contém um JSON. Abaixo temos uma string de JSON, porém, sem a função JSON não funciona. É importante lembrar que é necessário que, tanto o objeto da string de JSON quanto qualquer variável dentro dela esteja com aspas assim como o valor de uma string.
'{"nome": "Bonieky", "idade": 90}'

//O próprio navegador contém o JSON. Dentre as várias funções dele está a JSON.parse, que transforma uma string de JSON em um JSON.
//Agora a string é um JSON.
let pessoaPar = JSON.parse('{"nomePar": "Bonieky", "idadePar": 90}'
);

console.log(pessoaPar.nomePar);

console.log(pessoaPar);

//JSON.stringify
//A função stringify é o oposto da função parse, enquanto a função parse você passa um valor e ela retorna um JSON, a função stringify você passa um JSON e ela transforma em string.
let pessoaStr = JSON.stringify({nomeStr:'Bonieky', idadeStr:90});

console.log(pessoaStr);

//Vamos exemplificar em uma aplicação prática de uma requisição feita pelo mecanismo de pesquisa do Google, quando o usuário começa a digitar algo e já aparecem as sugestões abaixo (auto-complete).
//Input do usuário.
let busca = {input: 'bon'};

console.log(busca);  //(console.log apenas para entender o processo)

//Essa requisição é transformada em uma string.
buscaString = JSON.stringify(busca);

console.log(buscaString); //(console.log apenas para entender o processo)

//Após ser enviada para o servidor do Google, o resultado da requisição é o retorno de uma lista, porém ela vem em forma de string.
let resultado = {
    lista: [
        'bonieky',
        'bonieky lacerda',
        'bonito'
    ]
}

let resStr = JSON.stringify(resultado);

console.log(resStr);  //(console.log apenas para entender o processo)

//Agora é necessário tratar esse resultado para poder lê-lo.
let resJson = JSON.parse(resStr);

console.log(resJson);  //(console.log apenas para entender o processo)



//CÓDIGO SÍNCRONO E ASSÍNCRONO
//O código síncrono é executado linha por linha e a próxima linha tem que esperar a linha anterior ter finalizado sua execução.
let nomeSinc = 'Bonieky';
let sobrenomeSinc = 'Lacerda';
let nomeCompletoSinc = nomeSinc+' '+sobrenomeSinc;

//O código síncrono é executado conforme a necessidade do código, sem ordem específica de execução.
let nomeAssinc = 'Bonieky';
let sobrenomeAssinc = 'Lacerda';
//let TemperaturaAssinc = Maquininha.pegarTemperatura();  //Linha assíncrona
let nomeCompletoAssinc = nomeAssinc+' '+sobrenomeAssinc;



//CALLBACKS
//Essa função só é chamada quando um evento acontecer, caso contrário ela fica esperando.
function alertar(){
    alert("Opa, tudo bem?");
}

let nomeCB = 'Bonieky';
setTimeout(alertar, 2000);  //Linha assíncrona
let sobrenomeCB = 'Lacerda';

console.log("NOME COMPLETO = "+nomeCB+' '+sobrenomeCB);



//PROMISES
//Quando vamos fazer uma requisição assíncrona, ficamos com uma promessa de resultado. A função promise basicamente é um resultado temporário ou uma promessa de logo um dos três resultados irá se cumprir: ou nunca terá esse resultado, ou terá esse resultado daqui a um tempo ou algum problema vai acontecer.
function pegarTemperaturaProm() {
    return new Promise(function(resolve,reject){
        console.log("pegando temperatura...");

        setTimeout(function(){
            resolve('40 na sombra');
        }, 2000);
    })
}

//Usando a promise.
console.log('Código antes!');

let temp = pegarTemperaturaProm();

console.log('Código durante!');

temp.then(function(resultado){
    console.log("TEMPERATURA: "+resultado);
});
temp.catch(function(){
    console.log("Eita, deu erro!")
});

console.log('Código depois!');