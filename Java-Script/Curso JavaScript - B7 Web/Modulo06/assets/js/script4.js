//MANIPULANDO ATRIBUTOS
function trocarImagem(filename, animalName){
    document.querySelector('.imagem').setAttribute('src', 'assets/images/' + filename);
    document.querySelector('.imagem').setAttribute('data-animal', animalName);
}

function pegarAnimal() {
    let animal = document.querySelector('.imagem').getAttribute('data-animal');
    alert("O animal é: " + animal);
}



//DIMENSÕES
document.querySelector('.texto');

//Seleciona a largura total do objeto, incluindo padding e border.
document.querySelector('.texto').offsetWidth;

//Seleciona a altura total do objeto, incluindo padding e border.
document.querySelector('.texto').offsetHeight;

//Seleciona a largura total do objeto, incluindo padding e border, mas sem a barra de rolagem.
document.querySelector('.texto').clientWidth;

//Seleciona a altura total do objeto, incluindo padding e border, mas sem a barra de rolagem.
document.querySelector('.texto').clientHeight;

//Seleciona a largura total do conteúdo, ou seja, nesse caso, do texto.
document.querySelector('.texto').scrollWidth;

//Seleciona a altura total do conteúdo, ou seja, nesse caso, do texto.
document.querySelector('.texto').scrollHeight;



//DISTÂNCIAS E SCROLL SUAVE
//Dá a posição do scroll na parte superior.
document.querySelector('.texto').scrollTop;

//Dá a posição do scroll na esquerda.
document.querySelector('.texto').scrollLeft;

//Dá a posição do scroll na janela do navegador.
window.scrollY;

//Se o scroll é na tela inteira selecione como 'scrollY' ou 'scrollX'. Se for em um elemento, selecione o elemento e aplique com 'scrollTop' ou 'scrolLeft'.

//Para o scroll colar na parte superior da página.
document.querySelector('.texto').scrollTo(0, 0);

//Também funciona para a tela inteira.
window.scrollTo(0, 0);

//O smooth faz a tela ir para a posição de forma suave.
function subirTela(){
    window.scrollTo({
        top:0,
        behavior:'smooth'
    });
}

function decidirBotaoScroll(){
    if(window.scrollY === 0){
        //Se a posição do scroll na tela for igual à 0 vai ocultar o botão.
        document.querySelector('.scrollbutton').style.display = 'none';
    }
    else{
        //Se a posição do scroll na tela for diferente de 0 vai mostrar o botão.
        document.querySelector('.scrollbutton').style.display = 'block';
    }
}

//Essa função não é muito interessante nesse caso, pois ela checa atualizações de 1 em 1 segundo sem necessidade e isso pesaria no carregamento da página.
//setInterval(decidirBotaoScroll, 1000);

window.addEventListener('scroll', decidirBotaoScroll);