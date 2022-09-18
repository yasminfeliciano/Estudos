//- O que é uma função?
//É um conjunto de operações, códigos ou procedimentos independentes que, a partir de uma entrada de dados, geram um resultado.
//ENTRADA -> PROCESSAMENTO -> SAÍDA

//A função não aparece quando é definida, ela somente vai retornar algum resultado quando for solicitado. 
function gravidade()
{
    //Dentro de uma função o console log não retorna um resultado "visível"
    console.log ("A gravidade do planeta é:");
    console.log(9.8);
}

//Fora da função o 'console.log' retorna um resultado visível.
console.log("Opa, tudo bem?");

//Para solicitar a execução de uma função é necessário escrever seu nome, seguido de '()'.
gravidade();


//Ao colocar minhas variáveis dentro dos '()' estou criando parâmetros para minha função e essas variáveis só irão funcionar dentro da função, são variáveis locais.
function somar(n1, n2)
{
    let resultado = n1 + n2;
    console.log("Resultado: " + resultado);
}

//Quando você vai usar a função você deve definir os parâmetros que serão usados para que ela possa funcionar. 
somar(10, 15);

//As funções podem ser usadas várias vezes com parâmetros diferentes dentro de um mesmo código.
function nomeCompleto(nome, sobrenome)
{
    console.log(`${nome} ${sobrenome}`);
}

nomeCompleto("Bonieky", "Lacerda");
nomeCompleto("João", "Silva");

//O 'return' define o fim da minha função. Ao utilizá-lo eu digo ao código que depois dele não existe mais nada a ser processado.
function nomeCompletoo(nome, sobrenome)
{
    return `${nome} ${sobrenome}`;
    console.log("testando 1, 2, 3");
}
//O resultado não é exibido pois o return é quem está com os parâmetros da função
nomeCompletoo("Bonieky", "Lacerda");

//Ao definir uma variável de retorno, a função executa o código e essa variável pode ser exibida com o 'console.log'.
let completo = nomeCompletoo("Bonieky", "Lacerda");
console.log("Nome Completo: " + completo);

//Outra forma de exibir a função
console.log(nomeCompletoo("Bonieky", "Lacerda"));