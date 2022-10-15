//DATAS
let d = new Date();

//Retorna todas as informações de data e hora.
console.log(d);

//Retorna o mesmo valor obtido somente com a variável.
console.log(d.toString());

//Retorna a data de forma resumida.
console.log(d.toDateString());

//Retorna a data sem fuso horário(horário de greenwhich).
console.log(d.toUTCString());

//Datas com parâmetros definidos. O mês começa no 0 e termina no 11.
let dParam = new Date(2020,0,1,12,30,12);

console.log(dParam.toString());

//Datas do tipo date string.
let dString = new Date('2020-01-01 15:42:17');

console.log(dString.toString());

//Outro exemplo somente com ano e mês.
let dAnoMes = new Date(2022,2);
console.log(dAnoMes.toString());

//Exemplo de data 0. Essa foi a data que começou-se a contar os milisegundos de greenwhich.
let dZero = new Date(0);
console.log(dZero.toString());

//Data em milisegundos.
let dMiliSeg = new Date(857763120999);
console.log(dMiliSeg.toString());

//MANIPULANDO DATAS
//Para retornar o ano.
let pegarValorYear = d.getFullYear();

console.log(pegarValorYear);

//Para retornar o mês.
let pegarValorMonth = d.getMonth();

console.log(pegarValorMonth);

//Para retornar o dia da semana. Começando com 0 no domingo e terminando com 6 no sábado.
let pegarValorDiaSemana = d.getDay();

console.log(pegarValorDiaSemana);

//Para retornar o dia.
let pegarValorDia = d.getDate();

console.log(pegarValorDia);

//Para retornar a hora.
let pegarValorHora = d.getHours();

console.log(pegarValorHora);

//Para retornar a hora.
let pegarValorMinuto = d.getMinutes();

console.log(pegarValorMinuto);

//Para retornar a hora.
let pegarValorSegundos = d.getSeconds();

console.log(pegarValorSegundos);

//Para retornar o milisegundo do tempo atual.
let pegarValorMiliSeg = d.getMilliseconds();

console.log(pegarValorMiliSeg);

//Para retornar os milisegundos desde 31 de dezembro de 1969, 23:59:59.
let pegarValorTimestamp = d.getTime();

console.log(pegarValorTimestamp);

//Para retornar a hora.
let pegarValorNow = Date.now();

console.log(pegarValorNow);

//Todas as informações de ano, mês, dia, hora, minuto, segundo, etc., podem ser alteradas utilizando o 'set' invés de 'get'.

//Para definir o ano.
d.setFullYear(2022);

let novoValorYear = d;

console.log(novoValorYear);

//Para definir o ano.
d.setMonth(11);

let novoValorMonth = d;

console.log(novoValorMonth);

//Para acrescentar uma certa quantidade de dias ao dia atual.
d.setDate(d.getDate()+5);

let novoValorAcresDia = d;

console.log(novoValorAcresDia);

//Funciona com horas, minutos, segundos, etc.
d.setHours(d.getHours()+24);

let novoValorAcresHora = d;

console.log(novoValorAcresHora);