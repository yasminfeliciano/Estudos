//MÉTODOS DE ARRAYS
let lista = ['ovo', 'farinha', 'corante', 'massa'];

//Para transformar um 'array'em 'string' usa-se 'toString'.
let resString = lista.toString();

console.log(resString);

//Para transformar um 'array'em 'string' separando os itens com um critério usa-se 'join' e um parâmetro para determinar o critério.
let resJoin = lista.join('-');

console.log(resJoin);

//Para se obter a posição de um determinado item em um 'array' usa-se 'indexOF'.
let resultIndex = lista.indexOf('corante');

console.log(resultIndex);

//Para excluir o último item de um 'array' usa-se 'pop';
lista.pop();

let resPop = lista;

console.log(resPop);

//Para excluir o primeiro item de um 'array' usa-se 'shift';
lista.shift();

let resShift = lista;

console.log(resShift);

//Para adicionar um item em um 'array' usa-se 'push';
lista.push('prato');

let resPush = lista;

console.log(resPush);

//Para Substituir um item em um 'array' usa-se a posição do índice em que o item que será substituido está;
lista[0] = 'ovos';

let resSubst = lista;

console.log(resSubst);

//Para adicionar um item quando não se sabe qual o último item do 'array' pode-se usar o lenght.
lista[lista.length] = 'liquidificador';

let resLenght = lista;

console.log(resLenght)

//Para remover um item do 'array' também pode-se usar 'splice' usando 2 parâmetros, o primeiro para selecionar o item a ser removido e o segundo para a quantidade de itens a serem removidos. Caso não exista o segundo parâmetro todos os itens depois dele serão removidos.
lista.splice(1, 1);

let resSplice = lista;

console.log(resSplice);

//Para concatenar, juntar dois 'arrays' usa-se 'concat';
let lista2 = ['batedeira', 'trigo', 'forno'];

let resConcat = lista.concat(lista2);

console.log(resConcat);

//Para organizar um 'array' em ordem alfabética usa-se 'sort';
lista.sort();

let resSort = lista;

console.log(resSort);

//Para inverter a ordem de um 'array' usa-se 'reverse';
lista.reverse();

let resReverse = lista;

console.log(resReverse);

//Aqui foio criado um 2 'arrays', o segundo vai ser gerado através de uma função utilizando 'map' no primeiro 'array'.
let listaN = [45, 4, 9, 16, 25];

let listaNMap = [];

listaNMap = listaN.map(function(item){
    return item * 2;
})

let resMap = listaNMap;

console.log(resMap);

//Uma outra forma de fazer é utilizando o 'for'.
let listaNFor = [];

for(let i in listaN) {
    listaNFor.push(listaN[i]*2);
}

let resNFor = listaNFor;

console.log(resNFor);

//Para retornar um valor 'true' ou 'false' de itens específicos um 'array' pode-se usar 'filter'. A seleção terá apenas os itens que atenderem às condições.
let listaNFilter = [];

listaNFilter = listaN.filter(function(item){
    if(item < 20){
        return true;
    }
    else {
        return false;
    }
});

let resNFilter = listaNFilter;

console.log(resNFilter);

//Para retornar um valor 'true' ou 'false' para um 'array', onde todos os itens devem atender a uma condição específica, pode-se usar 'every'. O valor apenas será 'true' se todos itens atenderem à condição.
let listaNEvery = [];

listaNEvery = listaN.every(function(item){
    if(item > 20){
        return true;
    }
    else{
        return false;
    }
});

let resNEvery = listaNEvery;

console.log(resNEvery);

//Para retornar um valor 'true' ou 'false' para um 'array', onde pelo menos um item deve atender a uma condição específica, pode-se usar 'some'. O valor será 'true' se pelo menos um dos itens atender à condição.
let listaNSome = [];

listaNSome = listaN.some(function(item){
    if(item > 20){
        return true;
    }
    else{
        return false;
    }

    //O código acima pode ser resumido.
    //return(item > 20)? true : false;
});

let resNSome = listaNSome;

console.log(resNSome);

//Para retornar o primeiro item que satisfaça uma condição específica usa-se 'find', ele retorna o item.
let listaNFind = [];

listaNFind = listaN.find(function(item){
    return (item == 16) ? true : false;
});

let resNFind = listaNFind;

console.log(resNFind);

//Para retornar o primeiro item que satisfaça uma condição específica usa-se 'findIndex', ele retorna a posição do item.
let listaNFindIndex = [];

listaNFindIndex = listaN.findIndex(function(item){
    return (item == 16) ? true : false;
});

let resNFindIndex = listaNFindIndex;

console.log(resNFindIndex);

//Um exemplo, utilizando objetos mais complexos no 'array'.
let listaUsers = [
    {id: 1, nome: 'Bonieky', sobrenome: 'Lacerda'},
    {id: 2, nome: 'Paulo', sobrenome: 'XYZ'},
    {id: 3, nome: 'Fulano', sobrenome: 'Da Silva'}
];

let pessoa = listaUsers.find(function(item){
    return(item.sobrenome == 'XYZ') ? true : false;
    //Outro exemplo procurando pelo id.
    //return(item.id == 3) ? true : false;
});

let resUsersFind = pessoa;

console.log(resUsersFind);