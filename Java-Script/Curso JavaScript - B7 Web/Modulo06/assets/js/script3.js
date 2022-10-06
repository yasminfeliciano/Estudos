//TIPOS DE VARIÁVEIS
var nome = "Bonieky";   //string (palavra)
console.log(nome);
typeof nome;

var idade = 90;         //number (número)
console.log(idade);
typeof idade;

var salvo = true;       //boolean (boleana)
console.log(salvo);
typeof salvo;

var cidade;             //undefined (indefinida)
console.log(cidade);
typeof cidade;

//Como exemplo vamos fazer o console exibir o tipo de variável está em 'var tipo'.
var tipo = typeof idade;
console.log(tipo);



//COMENTÁRIOS

//Duas barras são comentários de uma linha.

/*Uma barra e um asterisco no começo e no final
são comentários de mais de uma linha.
A ordem dos símbolos se invertem no final*/



//FUNÇÕES
function alterar(){
    document.getElementById("titulo").innerHTML = "Trocou o titulo!";
    document.getElementById("campo").value = "Trocou o campo!";
}

//Aqui eu estou chamando a função para executar.
alterar();

//Exemplo de função com parâmetro.
alert("Funcionou!");

//Agora vamos adicionar um parâmetro na função 'alterar()', para isso vamos mudar o nome para 'alterarP()'.

function alterarP(tituloP){
    document.getElementById("tituloP").innerHTML = tituloP;
    document.getElementById("campoP").value = tituloP;
}

alterarP("Titulo de exemplo, colocado como parâmetro");

//Exemplo de função com dois parâmetros.
function somar(x, y){
    let total = x + y;
    document.getElementById("campo-somar").value = total;
}

somar(10, 94);

//Agora vamos utilizar o comando 'return', que é utilizado quando se espera que a função retorne alguma coisa.
function somarR(a, b){
    let totalR = a + b;
    return totalR;
}

var resultado = somarR(10, 15);

//Nesse caso não há nenhuma alteração no documento, mas podemos mostrar o resultado no console.
console.log(resultado);