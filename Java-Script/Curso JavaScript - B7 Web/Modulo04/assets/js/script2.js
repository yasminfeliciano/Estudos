var nome = "Bonieky";
var idade = 90;

alert(nome);

//===========================

var x = 10;
var y = 15

var total = x + y;

alert(total);

//===========================

var nome2 = "Bonieky";
var sobrenome = "Lacerda";
var nomeCompleto = nome2 + sobrenome;

alert(nomeCompleto);

//===========================

var hora = 12;

if (hora < 12) {
    console.log("Bom dia!");
}
else if (hora >= 12 && hora < 18) {
    console.log("Boa tarde!");
}
else if (hora <=23) {
    console.log("Boa noite!");
}

if (hora == 12 || hora == 18) {
    console.log("Você está na hora do rush!")
}

//===========================

//VAR, LET, CONST
//VAR
//Quando você define uma variável usando o 'var' acontece um processo chamado HOISTING e a variável é enviada para o escopo geral do seu script. Com isso você consegue usar essa variável como uma variável global, podendo ser usada no 'window', por exemplo. Ao declarar duas variáveis com o mesmo nome, a última variável é a que vai estar sendo usada pelo código.
var nomeVar = "João";

if (nomeVar == "João") {
    var idadeVar = 90;
}

console.log(idadeVar);

//LET
//Quando você define uma variável usando o 'let' ela fica disponível apenas naquele escopo específico de código. Se você tentar acessar ela de outro local não será possível, inclusive com o 'window'. Ao declarar duas variáveis com o mesmo nome, dá uma mensagem de erro dizendo que a variável em questão já foi definida anteriormente.
//Esse tipo de variável só funciona se o console estiver dentro da função, caso contrário, o console irá mostrar a mensagem: 'idadeLet is not defined', porque esse tipo de variável é local e não global. A utilização do 'let', em muitos casos, reduz o consumo de memória, uma vez que, logo após a execução da função as variáveis locais são removidas da memória. Isso também evita a confusão por excesso de variáveis que não estão sendo utilizadas em outras partes do código.
let nomeLet = "Pedro";

if (nomeLet == "Pedro") {
    let idadeLet = 12;
    console.log(idadeLet);
}

//console.log(idadeLet);

//CONST
//A variável 'const' não pode ser alterada em qualquer outro momento no código. Irá aparecer uma mensagem de erro dizendo que a constante não pode ser mudada. Porém se eu quiser alterar o conteúdo do objeto da constante eu posso.
const nomeConst = "Lucas";
//nomeConst = "Nathan"

console.log(nomeConst);

//Outro exemplo alterando o conteúdo do objeto. A constante nomeCompletoConst possui 2 variáveis dentro dela (nome e sobrenome) que não podem ser removidas ou substituídas, porém seu conteúdo (Bruno e Castro) podem ser modificados.
const nomeCompletoConst = {nome:"Bruno", sobrenome:"Castro"};

console.log(nomeCompletoConst);

nomeCompletoConst.nome = "Thiago";
nomeCompletoConst.sobrenome = "Pereira";

console.log(nomeCompletoConst);