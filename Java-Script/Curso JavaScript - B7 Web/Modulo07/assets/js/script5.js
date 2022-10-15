//MATEMÁTICA
//Constante PI
let novoValorPI = Math.PI;

console.log(novoValorPI);

//Arreadonda o valor.
let novoValorRound = Math.round(3.67);

console.log(novoValorRound);

//Arredonda o valor para baixo.
let novoValorFloor = Math.floor(3.67);

console.log(novoValorFloor);

//Arredonda o valor para cima.
let novoValorCeil= Math.ceil(3.67);

console.log(novoValorCeil);

//Retorna o valor absoluto do número.
let novoValorAbs = Math.abs(-9.65464);

console.log(novoValorAbs);

//Retorna o valor mínimo.
let novoValorMin = Math.min(7, 100, 600, 20, 3);

console.log(novoValorMin);

//Retorna o valor máximo.
let novoValorMax = Math.max(7, 100, 600, 20, 3);

console.log(novoValorMax);

//Retorna um valor aleatório entre 0 e 1.
let novoValorRandom = Math.random();

console.log(novoValorRandom);

//Com uma combinação de funções é possível fazer com que o random retorne um valor inteiro aleatório entre dois números. Multiplica-se a função pelo número máximo e arredonda o valor obtido para baixo, para garantir que o número gerado não irá ultrapassar o número máximo.
let novoValorRandomInt = Math.floor(Math.random()*100);

console.log(novoValorRandomInt);

//Retorna o valor do seno.
let novoValorSin = Math.sin(45);

console.log(novoValorSin);

//Retorna o valor do cosseno.
let novoValorCos = Math.cos(45);

console.log(novoValorCos);

//Retorna o valor da tangente.
let novoValorTan = Math.tan(45);

console.log(novoValorTan);