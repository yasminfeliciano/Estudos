//Na maioria dos casos, o que foi criado dentro da função pertence ao contexto da função e podem não funcionar fora dela
//function add(){
//    let count = 0;
//    count++;
//}

let count = 0;

//Variáveis locais temprioridade em relação às variaveis globais.
function add(){
    //então se eu comentar essa linha o código funciona com a variável global e me retorna o resultado esperado.
    //let count = 0;
    count++;
}

add();
add();

console.log(count);



function addSquares(a, b){
    function square(x){
        return x * x;
    }
    let sqrA = square(a);
    let sqrB = square(b);
    //return square(a) + square(b);
    //ou
    return sqrA + sqrB;
}

console.log(addSquares(2, 3));



//Um 'Array' pode armazenar muitos tipos de variáveis, inclusive se forem de tipos diferentes entre si.
let colors = ['blue', 'red', 'green'];

console.log(colors[0]);

let age = [10, 20, 30];

console.log(age[1]);

let list = ['algo', 30, true];

console.log(list[2]);

//Um 'Array' também pode armazenar outros 'Arrays'.
let names = ['Bonieky', 'Pedro', 'Silvia'];

console.log(names[0]);

let nameList = ['Patrícia', names, 'Jorge'];

console.log(nameList[1]);

let anotherList = ['alguma coisa', 'outra coisa', ['coisa a', 'coisa b']];

console.log(anotherList[2]);
//Aqui quero apenas exibir a 'coisa a' que está num 'Array' dentro de outro 'Array'
console.log(anotherList[2][0]);



let ingredientes = [
    'agua',
    'farinha',
    'ovo',
    'corante',
    'sal',
]

//Quando se usa a função 'push' se adiciona itens à lista que automaticamente terão índices sucessores do último item da lista.(Ex: 0, 1, 2, 3, 4, => 5) Ítem 5 adicionado.
ingredientes.push('cebolinha');

//Quando se usa a função 'pop' se remove o último item da lista.(Ex: 0, 1, 2, 3, 4, <= 5) Ítem 5 removido.
ingredientes.pop();

//Quando se usa a função 'shift' se remove o primeiro item da lista.(Ex: 0 <= , 1, 2, 3, 4, 5) Ítem 0 removido.
ingredientes.shift();

//Quando se coloca um item que seu índice não segue a ordem, ou seja, não é sucessor do último índice, ele entende que os índices anteriores são vazios e segue a contagem a partir do item adicionado por último.(Ex: 0, 1, 2, 3, 4, 5, (6 = item vazio) => 7)
ingredientes[7] = 'cebola';

console.log(`Total de ingredientes: ${ingredientes.length}`);