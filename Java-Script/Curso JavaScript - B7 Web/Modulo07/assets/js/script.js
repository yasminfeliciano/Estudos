//MÉTODOS DE STRING
let nome = 'Bonieky Lacerda Leal';

//a função 'lenght' vai pegar a extensão da variável procurada. No caso de uma string, por exemplo, vai resultar na quantidade de letras que contém.
let resultado = nome.length;

console.log(resultado);

//O 'indexOF' vai procurar onde começa a palavra que está entre parênteses, lembrando que a contagem começa no 0.
let resultIndex = nome.indexOf('Lacerda');

//Caso não haja correspondência na pesquisa o resultado é -1.
let resultIndexNaoAchou = nome.indexOf('Silva');

//Um exemplo de aplicação.
if(nome.indexOf('Pedro') > -1){
    result = 'Achou!';
}
else{
    result = 'Não Achou!'
}

console.log(result);

//O 'slice' basicamente pega um pedaço específico da variável, Sendo o primeiro parâmetro a posição inicial e o segundo a posição final. 
let resultSlice = nome.slice(10, 15);

console.log(resultSlice);

//Se colocar apenas um número ele vai pegar da letra correspondente a aquele número até o final da string.
let resultSliceNum = nome.slice(11);

console.log(resultSliceNum);

//Se for um número negativo ele vai pegar os últimos caracteres da string correspondente ao número, podendo também, ter um ou dois parâmetros, número inicial e final.
let resultSliceNumNeg = nome.slice(-6);

console.log(resultSliceNumNeg);

//O 'substring' funciona assim como o 'slice', porém não tem a opção de pegar a partir de um número negativo. Também tem dois parâmetros sendo um número inicial e um outro o final.
let resultSubstring = nome.substring(10, 15);

console.log(resultSubstring);

//O "substr" tem seu comportamento diversificado de forma que o primeiro parâmetro é a posição inicial e o segundo a quantidade de letras a pegar depois do número inicial. 
let resultSubstr = nome.substr(8, 15);

console.log(resultSubstr);

//O 'substr' também funciona com números negativos.
let resultSubstrNeg = nome.substr(-4, 2);

console.log(resultSubstrNeg);

//O 'replace' substitui uma parte específica de uma string.
let resultReplace = nome.replace('Lacerda', 'Silva');

console.log(resultReplace);

//Outro exemplo de aplicação.
let auto = 'Eu gosto de carros';

let resultReplaceAutomovel = auto.replace('carros', 'motos');

console.log('Frase: ', auto);

console.log('Resultado: ', resultReplaceAutomovel);

//Para deixar a string toda em letra maiúscula usa-se 'toUpperCase'.
let resultUpperCase = nome.toUpperCase();

console.log(resultUpperCase);

//Ou para deixar toda em letra minúscula 'toLowerCase'.
let resultLowerCase = nome.toLowerCase();

console.log(resultLowerCase);

//A função 'concat' basicamente concatena duas variáveis, porém é muito pouco utilizada.
let primeiroNome = 'Pedro';

let resultConcat = primeiroNome.concat(' Silva');

console.log("resultado: ", resultConcat);

//Para eliminar os espaços em branco usa-se a função 'trim'.
let nomeComEspacos = '     Giovana     ';

let resultTrim = nomeComEspacos.trim();

console.log("resultado: ", resultTrim);

//Aplicando o 'lenght' temos a contagem de caracteres.
let resultTrimCount = nomeComEspacos.trim().length;

console.log(resultTrimCount);

//Para saber qual o caracter ocupa certa posição pode-se usar o 'charAt'.
let resultChar = nome.charAt(3);

console.log(resultChar);

//Esse mesmo resultado pode ser obtido como se considerasse a string como um array, mas sem que realmente seja um array.
let resultCharArray = nome[3];

console.log(resultCharArray);

//Agora, para transformar uma string em um array usa-se o 'split' com um parâmetro para ser o critério de divisão. No caso abaixo, como um espaço está sendo utilizado, tenho um array com 3 itens.
let resultArray = nome.split(' ');

console.log(resultArray);

//Já nesse caso estou usando a letra 'e', portanto vou ter um array com quatro itens, apesar da divisão estar um pouco estranha.
let resultArrayE = nome.split('e');

console.log(resultArrayE);