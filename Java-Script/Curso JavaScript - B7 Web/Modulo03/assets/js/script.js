//DOM = Document Object Model

//A função abaixo vai pegar todos os elementos do documento que estão relacionados com a tag requisitada e armazenar. No exemplo abaixo irá armazenar todas as tags h1 em um array, pois há mais de um elemento e está no plural('Elements').  
document.getElementsByTagName("h1")

//Eu posso salvar o array acima como uma variável.
let elementos = document.getElementsByTagName("h1")

//Posso selecionar vários elementos como por exemplo uma div.
document.getElementsByTagName("div")

//Posso selecionar por um id. Inclusive, por só poder ter um elemento com um nome de id, ao invés de 'Elements' escreve-se 'Element'.
document.getElementById("#teste")

//Posso selecionar um elemento através da class dele.
document.getElementsByClassName(".botao")

//Nessa função funciona basicamente como um CSS, só precisa colocar o nome da tag que ele acha, porém ele só seleciona o primeiro item. O document.querySelector sempre retorna um objeto.
document.querySelector("h1")

//Para o document.querySelector selecionar todos os itens de uma tag é necessário complementar a função.
document.querySelectorAll("li")

//Também posso pegar elementos em camadas, na hierarquia do HTML.
document.querySelectorAll("#teste ul li")

//A função document.querySelectorAll sempre vai me retornar um array, mesmo que só exista um objeto com aquela tag, classe, ou id. Já o document.querySelector sempre retorna um objeto.
document.querySelectorAll(".botao")



//EVENTOS DE CLICK
//A função abaixo identifica se houve algum evento de click no documento.
function clicou(){
    console.log("Clicou no botão!");
}

//A função também pode ser definida e chamada dentro do próprio javascript.
//Primeira forma
let botao = document.querySelector(".botao");
botao.addEventListener("click", clicou)

//Segunda forma
//let botao = document.querySelector(".botao");
botao.addEventListener("click", function(){
    clicou();
});

//Terceira forma
//let botao = document.querySelector(".botao");
botao.addEventListener("click", () => {
    clicou();
});