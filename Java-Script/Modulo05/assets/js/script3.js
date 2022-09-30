let carros = ['Palio', 'Uno', 'Corola', 'Ferrari'];

console.log(carros[2]);

//Os arrays podem ter funções como um dos itens, porém nesse caso elas não devem ter nomes.
let carros2 = [
    'Palio',
    'Uno',
    'Corola',
    'Ferrari',
    function(){
       console.log('Testando 1, 2, 3...'); 
    }
] 

//Aqui estou chamando a função do array para ser executada
carros2[4]();

let ingredientes = [
    ['uva', 'pera', 'maça'],
    ['arroz', 'macarrão']
];

console.log(ingredientes)

console.log(ingredientes[1][0]);