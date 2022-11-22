//FETCH COM POST
//Abaixo está sendo feita uma requisição do tipo post para o servidor.
async function inserirPost() {
    document.getElementById("posts").innerHTML = "Carregando...";

    let req = await fetch('https://jsonplaceholder.typicode.com/posts', {
        method: 'POST',
        body: JSON.stringify({
            title: 'Titulo de teste',
            body: 'Corpo de teste',
            userId: 4
        }),
        headers: {
            'Content-Type': 'application/json'
        }
    });
    let json = await req.json();

    console.log(json);
}



//UPLOAD DE ARQUIVOS COM JS
async function enviar(){
    let arquivo = document.getElementById('arquivo').files[0];
    console.log(arquivo);

    let body = new FormData();
    body.append('title', 'Bla bla bla');
    body.append('arquivo', arquivo);

    let req = await fetch('https://www.meusite.com.br/upload', {
        method: 'POST',
        body: body,
        headers: {
            'Content-Type': 'multipart/form-data'
        }
    });
}



//THUMBNAILS COM JS
function mostrar(){
    let imagem = document.getElementById("imagem").files[0];

    let img = document.createElement('img');
    img.src = URL.createObjectURL(imagem);
    img.width = 200;
    
    document.getElementById("area").appendChild(img);
}



//THUMBNAILS COM FILEREADER
function mostrar2(){
    let reader2 = new FileReader();
    let imagem2 = document.getElementById('imagem2').files[0];

    reader2.onload = function(){
        let img2 = document.createElement('img2');
        img2.src = reader2.result;
        img2.width = 200;

        document.getElementById('area2').appendChild(img2);
    }
    reader2.readAsDataURL(imagem2);
}