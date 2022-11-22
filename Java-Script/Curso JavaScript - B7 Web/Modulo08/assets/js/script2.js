//FETCH
//A função fetch retorna uma promise. 
async function loadPosts(){   //O async obriga a função esperar o resultado.
    document.getElementById("posts").innerHTML = 'Carregando...';

    /*
    fetch('https://jsonplaceholder.typicode.com/posts')
        .then(function(resultado){
            return resultado.json();
        })
        .then(function(json){
            montarBlog(json);
        })
        .catch(function(error){
            console.log("Deu problema!");
        })
    */

    //Pode ser escrito da forma acima (menos compacta) ou da forma abaixo (mais compacta).

    let req = await fetch('https://jsonplaceholder.typicode.com/posts');
    let json = await req.json();
    montarBlog(json);
}

function montarBlog(lista) {
    let html = '';

    for(let i in lista){
        html += '<h3>'+lista[i].title+'</h3>';
        html += lista[i].body+'<br/>';
        html += '<hr/>';
    }

    document.getElementById("posts").innerHTML = html;
}

//ASYNC E AWAIT
//Por ter a possibilidade de gerar algum problema quando função solicita um resultado e não obter no momento, pois é uma função assíncrona, podemos utilizar o async é o comando que basicamente irá obrigar a função esperar o ressultado. Ele é utilizado com o await, que é utilizado cada vez que o código tiver uma promise que está esperando um resultado.



//Em uma arrow function usa-se assim.
//let loadPosts = async () =>{      }