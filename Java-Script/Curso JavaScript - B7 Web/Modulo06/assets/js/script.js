//É possível alterar o HTML através do 'document', inclusive adicionar objetos e tags.
document.getElementById('exemplo').innerHTML = "Pedro <button>Botão</button>";

//Aqui eu estou selecionando um objeto que contenha a classe "lista".
document.getElementsByClassName('lista');

//Aqui estou alterando o conteúdo da tag.
document.getElementsByClassName('lista')[1].innerHTML = 'Era um array, agora eu mudei!';

//Aqui eu estou selecionando um objeto que contenha a tag 'button'.
document.getElementsByTagName('button');

//Aqui eu estou selecionando outro objeto através de uma outra tag, 'input'.
document.getElementsByTagName('input');

//Aqui eu estou selecionando um objeto pelo name, "telefone".
document.getElementsByName('telefone');