//ARROW FUNCTIONS
//Função comum
function somarComum(x, y) {
    return x + y;
}

console.log(somarComum(10, 5));

//Função sem nome, pois está dentro de uma variável.
let somarSemNome = function(x, y) {
    return x + y;
}

console.log(somarSemNome(10, 5));

//Função Arrow (função anônima).
let somarArrow = (x, y) =>{
    return x + y;
}

console.log(somarArrow(10, 5));

//A Função Arrow pode ser escrita sem as chaves de uma função, apenas se logo depois vier a operação da função, caso contrário, se estiver utilizando o return, por exemplo, é necessário o uso das chaves.
let somarArrow2 = (x, y) => x + y;

console.log(somarArrow2(10, 5));

//Uma opção para quando a função tem apenas um parâmetro.
let letrasNoNome = (nome) => {
    return nome.length;
}

console.log(letrasNoNome('Bonieky'));

//Também dá para fazer dessa forma, e por ter somente um parâmetro o parêntese nesse caso é opcional.
let letrasNoNome2 = nome => nome.length;

console.log(letrasNoNome2('Bonieky'));

//Agora, quando a função não tem parâmetro é necessário usar o parêntese.

//OBS.: Na Arrow Function (função anônima) não tem o objeto 'this' (que diz respeito ao item anterior, que está para fora), ou seja, se vai precisar usar 'this', então o recomendado é que se use uma função normal.



//OPERADOR SPREAD
//O operador spread vai adicionar o conteúdo de um array como parte de outro. 
let numeros = [1, 2, 3, 4];

let outros = [...numeros, 5, 6, 7, 8];

console.log(outros);

//Agora, se eu simplesmente colocar o nome do array sem os 3 pontinhos ele vai colocar o próprio array dentro do outro.

let outrosArray = [numeros, 5, 6, 7, 8];

console.log(outrosArray);

//Outro exemplo de operador spread.
let info = {
    nome: 'Bonieky',
    sobrenome: 'Lacerda',
    idade: 90
};

let novaInfo = {
    ...info,
    cidade: 'Campina Grande',
    estado: 'Paraiba',
    pais: 'Brasil'
};

console.log(novaInfo);

//Um exemplo aplicado em uma função. 
function adicionarInfo (infoFuncao){
    let novasInfoFuncao = {
        ...infoFuncao,
        status: 0,
        token: 'algum token',
        data_cadastro:'01/01/2021'
    }
    return novasInfoFuncao;
}

console.log(adicionarInfo({nome: 'Bonieky', sobrenome: 'Lacerda'}));



//OPERADOR REST
//O operador rest é muito parecido com o operador spread. Nesse caso ele irá funcionar como um "substituto" para os parâmetros da função no caso de, por exemplo, não sabermos a quantidade de parâmetros ou de ser inviável colocar uma grande quantidade de parâmetros na função.
function adicionar(...numerosRest) {
    console.log(numerosRest);
}

adicionar(5, 6, 7, 8, 9, 10);

//Agora faremos um pequeno exercício para a aplicação dos dois operadores (spread e rest).
function adicionarEx(nomesEx, ...novosNomesEx){
    let novoConjuntoEx = [
        ...nomesEx,
        ...novosNomesEx
    ];

    return novoConjuntoEx;
}

let nomesEx = ['Bonieky', 'Paulo']

let outrosEx = adicionarEx(nomesEx, "Antonio", "Maria", "José");

console.log(outrosEx);



//FUNÇÃO INCLUDES
//A função includes verifica em um array se o termo do parâmetro está incluso nesse array. O termo deve estar exatamente igual, considerando também letras maiúsculas e minúsculas.
let lista = ['ovo', 'café', 'arroz', 'feijão', 'macarrão']

console.log(lista.includes('ovo'));

//Essa função também funciona para strings.
let nomeIn = 'Bonieky';

console.log(nomeIn.includes('a'));

//FUNÇÃO REPEAT
//A função repeat repete várias vezes uma expressão no console.
console.log('x'.repeat(20));

//Outro exemplo
let nomeRe = 'Bonieky';

console.log(nomeRe.repeat(2));



//KEY, VALUES E ENTRIES
//Nas listas abaixo percebemos que tanto um array como um objeto, são considerados objects(objetos) pelo console, portanto keys, values e entries irão funcionar para arrays e objetos.
let lista1 = [1, 2, 3, 4]; //Array

console.log(typeof lista1);

let lista2 = {nome: 'Bonieky', idade: 90}; //Objeto

console.log(typeof lista2);

//Vejamos um exemplo de array com o key, que irá retornar um array com os índices dos itens.
let lista3 = ['ovo', 'macarrão', 'feijão', 'pipoca'];

console.log(Object.keys(lista3));

//Vejamos, agora o mesmo exemplo com o values, que irá basicamente retornar um array com os valores do próprio array.
console.log(Object.values(lista3));

//Agora esse exemplo com o entries, que irá retornar um array com um array para cada item, contendo o índice e o valor do array.
console.log(Object.entries(lista3));

//Exemplo com um objeto
let pessoa = {
    nomePes: 'Bonieky',
    sobrenomePes: 'Lacerda',
    idadePes: 90
};

console.log(Object.keys(pessoa));

console.log(Object.values(pessoa));

console.log(Object.entries(pessoa));



//PADSTART E PADEND
//O padEnd preenche o conteúdo que falta para completar a sentença requerida. No caso abaixo temos os 4 primeiros números de 9 que precisam ser preenchidos, então os demais serão preenchidos com '*+'.
let telefone1 = '5478'

console.log(telefone1.padEnd(9,'*+'));

//O padStart funciona quase igual ao padEnd, porém completa no início da sentença. No caso abaixo temos os 3 últimos números de 7 que precisam ser preenchidos, então os demais serão preenchidos com '-='.
let telefone2 = '629'

console.log(telefone2.padEnd(7,'-='));

//Vamos agora para um exemplo prático para exibir somente os 4 últimos dígitos do cartão.
let cartao = '1234123412341234';

let lastDigits = cartao.slice(-4);

let cartaoMascarado = lastDigits.padStart(16,'*');

console.log('Este é o seu cartao? ' + cartaoMascarado);

//Agora um outro exemplo prático para exibir somente os 5 primeiros dígitos do CPF.
let cpf = '12345678900';

let firstDigits = cpf.slice(0, 5);

let cpfMascarado = firstDigits.padEnd(12,'*');

console.log('Este é o seu CPF? ' + cpfMascarado)