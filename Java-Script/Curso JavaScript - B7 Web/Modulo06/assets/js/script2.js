//Os comandos abaixo geram o mesmo resultado.
document.querySelector('#exemplo');
document.getElementById('exemplo');

//O comando abaixo vai selecionar apenas o PRIMEIRO elemento que atende à condição.
document.querySelector('.lista');

//O comando abaixo vai selecionar TODOS os elementos que atendem à condição.
document.querySelectorAll('.lista');

//Os comandos abaixo vão selecionar e alterar o texto do botão.
document.querySelector('button');

document.querySelector('button').innerHTML = 'Alguma Coisa';

document.querySelector('button').innerHTML = 'Inscreva-se';

//Para alterar um elemento específico quando existe mais de um elemento é só indicar o índice.
document.querySelectorAll('.lista');

document.querySelectorAll('.lista')[1].innerHTML = 'Alterado!';




function verde(){
    document.querySelector('#exemplo').classList.remove('vermelho');
    document.querySelector('#exemplo').classList.remove('azul');
    document.querySelector('#exemplo').classList.add('verde');
}

function vermelho(){
    document.querySelector('#exemplo').classList.remove('verde');
    document.querySelector('#exemplo').classList.remove('azul');
    document.querySelector('#exemplo').classList.add('vermelho');
}

function azul(){
    document.querySelector('#exemplo').classList.remove('vermelho');
    document.querySelector('#exemplo').classList.remove('verde');
    document.querySelector('#exemplo').classList.add('azul');
}

function trocar(){
    if(document.querySelectorAll('button')[4].classList.contains('preto')) {
        document.querySelectorAll('button')[4].classList.remove('preto');
        document.querySelectorAll('button')[4].classList.add('verde');
    }
    else {
        document.querySelectorAll('button')[4].classList.remove('verde');
        document.querySelectorAll('button')[4].classList.add('preto');
    }
}