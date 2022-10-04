let fruits = ['maça', 'uva', 'laranja','banana'];

fruits.push('kiwi');

console.log(fruits);
console.log(fruits.length);

fruits.pop();
console.log(fruits);

fruits.shift();
console.log(fruits);

//Join junta todos os itens do array
console.log(fruits.join(', '));

fruits[0] = 'pêra';
console.log(fruits);

fruits[fruits.length - 1] = 'abacaxi';
console.log(fruits);

//Sort organiza todos os itens da lista em ordem alfabetica
fruits.sort();
console.log(fruits);

//Reverse inverte a ordem dos itens do array
fruits.reverse();
console.log(fruits);

//A função abaixo filtra apenas as frutas que tem mais de 4 letras
let bigFruits = fruits.filter((item) => {
    if(item.length > 4){
        return true;
    }
    else{
        return false;
    }
})
console.log(bigFruits);

//A funçao acima pode ser simplificada da seguinte forma
let bigFruits2 = fruits.filter((item) => {
    if(item.length > 4);
})
console.log(bigFruits);

//A função abaixo verifica se as frutas tem mais de 3 letras. A função every exige que todos os itens satisfaçam a condição.
let ok = fruits.every((value) => {
    return value.length > 3;
});
if(ok){
    console.log('Todos são maior que 3');
}
else{
    console.log('Não são todos maior que 3');
}

//A função abaixo verifica se as frutas tem mais de 3 letras. A função every exige que pelo menos 1 item satisfaça a condição.
let ok2 = fruits.every((value) => {
    return value.length > 3;
});
if(ok2){
    console.log('Alguns itens são maior que 3');
}
else{
    console.log('nenhum item é maior que 3');
}

//A função includes verifica se algum item está incluso no array
if(fruits.includes('uva')){
    console.log('Tem uva sim!');
}
else{
    console.log('Não tem uva...')
}




//A função abaixo compara e organiza os itens de um array de acordo com a necessidade.
let cars = [
    {brand:'Fiat', year:2022},
    {brand:'BMW', year:2018},
    {brand:'Ferrari', year:2020}
]

cars.sort((a, b) => {
    if(a.year > b.year){
        return 1;
    }
    else if(a.year < b.year){
        return -1;
    }
    else{
        return 0;
    }
});
console.log(cars);

//A funçao acima pode ser simplificada da seguinte maneira
cars.sort((a, b) => {
    return a.year - b.year;
})
console.log(cars);