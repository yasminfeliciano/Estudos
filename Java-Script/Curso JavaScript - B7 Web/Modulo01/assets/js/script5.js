//= é para atribuir um valor a uma variável
//== é usado para comparação dentro das funções, porém não é tão restrita, podendo ser usada para comparar uma string com um número, etc.
//=== é usado para comparação dentro das funções, porém é mais restrito, somente comparando variáveis do mesmo tipo, como string com string, número com número, etc.

let idadee = "30";
if(idadee==30)
{
    console.log("Você tem 30 anos");
}

let idadeee = 40;
if(idadeee===40)
{
    console.log("Você tem 40 anos");
}



let idade = 45;

//'if' não precisa estar acompanhado do 'else'.
if(idade >= 18) 
{
    console.log("você é maior de idade.");
}
else
{
    console.log("você é menor de idade.");
}

//Neste exemplo só será exibida a mensagem para uma idade entre 18 e 59, através de duas condicionais processadas separadamente
if (idade>=18)
{
    if (idade < 60)
    {
        console.log("Você é um adulto");
    }
}

//Neste exemplo só será exibida a mensagem para uma idade entre 18 e 59 anos, porém temos duas condicionais processadas ao mesmo tempo a serem respeitadas pelo código.
if (idade >= 18 && idade < 60)
{
    console.log("Você é um adulto");
}

//Neste outro exemplo vemos uma condicional tripla com as condicionais independentes, ou seja, com 3 possibilidades de resultado usando 'if'.
if (idade < 18)
{
    console.log("Você é uma criança");
}
if (idade >= 18 && idade < 60)
{
    console.log("Você é um adulto");
}
if (idade >= 60)
{
    console.log("Você é um idoso");
}

//Neste exemplo temos as mesmas condições no de cima com a mesma estrutura, porém ao usar o else, o código não verifica uma por uma pra ver qual é a condição verdadeira, se a primeira satisfaz a condição ele para de verificar as outras condições e pula para a próxima função, se a primeira não satizfaz ele tenta a segunda, e assim sucessivamente.
if (idade < 18)
{
    console.log("Você é uma criança");
}
else if (idade >= 18 && idade < 60)
{
    console.log("Você é um adulto");
}
else if (idade >= 60)
{
    console.log("Você é um idoso");
}



//Podemos determinar uma variável boolean true ou false para obter determinado resultado no 'if'.
let ok = false;
if (ok)
{
    console.log("Entrou no IF");
}
else
{
    console.log("Não entrou no IF");
}

//Também podemos usar o true ou false para fazer essa verificação do resultado fora do 'if' e teremos a resposta true ou false através do 'if'.
let verificacao = idade >= 18 && idade < 60;
if(verificacao)
{
    console.log("É adulto");
}
else
{
    console.log("Não é adulto");
}

//Podemos verificar a boolean dentro da própria função para retornar-nos um valor true ou false.
console.log(idade>18);
