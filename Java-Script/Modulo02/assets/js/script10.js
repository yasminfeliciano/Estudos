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

