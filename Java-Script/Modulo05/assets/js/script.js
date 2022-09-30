function clicou() {
    alert("Você clicou no botão!");
    document.getElementById("titulo").innerHTML = "Obrigado!";
}

function digitou(){
    console.log("Você digitou");
}

function digitou2(e){
    console.log(e);
    if(e.keyCode == 13 && e.ctrlKey == true){ //Enter
        let texto = document.getElementById("campo").value;
        console.log(texto);
    }
}