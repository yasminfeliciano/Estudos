let x = 2;
x = x + 8;

let y = "2";
y = y + 8;

console.log(x);
//na primeira equação ele entende o número como um numeral, variável operacional

console.log(y);
//na segunda equação ele entende o número como uma string, que é uma variável não operacional.



let n1 = 15;
let n2 = 20;

let soma = n1 + n2;

//Primeira meneira de representar um resultado através da soma dentro da função console
console.log(n1+n2);
//Segunda maneira de representar um resultado através da soma fora da função console
console.log(soma);



let nome = "Yasmin";
let sobrenome = "Feliciano";
let nomeCompleto = nome +" "+ sobrenome; //string normal(usa "")
console.log(nomeCompleto);

let nomeCompletoo = 'bla bla bla'; //template string (usa '')
console.log("Nome: "+nomeCompletoo);

let nomeCompletooo = `${nome} ${sobrenome}`;
console.log("Nome: "+ nomeCompletooo);

let idade = 25;
let idadeString = `Idade: ${idade+2} anos`;
console.log(idadeString);