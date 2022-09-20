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