//SWITCH
let dia = 3;
let diaNome = '';

switch(dia){
    case 1:
        diaNome = 'Segunda-Feira';
        break;
    case 2:
        diaNome = 'Terça-Feira';
        break;
    case 3:
        diaNome = 'Quarta-Feira';
        break;
    case 4:
        diaNome = 'Quinta-Feira';
        break;
    case 5:
        diaNome = 'Sexta-Feira';
        break;
    case 6:
        diaNome = 'Sábado';
        break;
    case 7:
        diaNome = 'Domingo';
        break;
}

document.getElementById("dia").innerHTML = "Hoje é: "+diaNome;

let diaFDS = 5;
let diaNomeFDS = '';

switch(diaFDS){
    case 6: //caso 6 ou 7
    case 7:
        diaNomeFDS = 'Final de Semana';
        break;
    default:
        diaNomeFDS = 'Dia de Semana';
        break;
}



//FOR LOOP
let texto = '';

for(let i = 0; i < 50; i++){
    texto = texto + i + '<br/>';
}

document.getElementById("demo").innerHTML = texto;



//FOR LOOP ARRAY
let carros  = ['Ferrari', 'Fusca', 'Palio', 'Corolla', 'lamborghini'];

let html = '<ul>';

for(let i in carros){
    html+='<li>' + carros[i] + '</li>';
}

html += '</ul>';

document.getElementById("carros").innerHTML = html;



//WHILE
let htmlWhile = '';

let c = 1;

while(c <= 10){
    htmlWhile += "Número: " + c + "<br/>";
    c++;
}

//O 'for' exemplificado abaixo gera o mesmo resultado do 'while' acima.
for(let c = 1; c <= 10; c++){
    htmlWhile += "Número: " + c + "<br/>";
}

document.getElementById("exWhile").innerHTML = htmlWhile;



//QUERY SELECTOR ALL
document.getElementsByClassName('subtitulo');

//Para selecionar uma tag com uma class específica
document.querySelector('ol.lista');

//Selecionar e mudar uma tag por um id
document.querySelector('#titulo-receita');

document.querySelector('#titulo-receita').innerHTML = 'Esta é uma receita de bolo';

//Caso haja mais de um item com a mesma classe o 'querySelector' apenas o primeiro é selecionado, uma vez que aquele item satisfaz a condição.
document.querySelector('.lista');

document.querySelector('li');

//Para selecionar todos os itens que satisfaçam a condição deve-se utilizar 'querySelectorAll' e ele vai retornar um 'array' com todos os elementos que satisfaçam a condição.
document.querySelectorAll('.lista');

document.querySelectorAll('li');

//Para gerar esse 'array', pode-se definir uma variável com esse comando.
let lista = document.querySelectorAll('li');

//Abaixo temos um exemplo de como utilizar num comando 'for', por exemplo.
for(let i in lista){
    lista [i].style.color = '#f00';
}

//Também posso utilizar o 'querySelector' para fazer modificações no 'body'.
document.querySelector('body').style.color = '#ff0';