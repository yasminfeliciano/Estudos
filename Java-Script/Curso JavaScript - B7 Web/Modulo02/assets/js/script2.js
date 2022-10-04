function maiorDeIdade(idade)
{
    if (idade >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Aqui eu executo e exibo o resultado da minha função
let verificacao = maiorDeIdade(14);
console.log(verificacao);

//Aqui eu executo, exibo o resultado da minha função e dou um parecer sobre ela além do true ou false
let idade = 10;
let verificacaoo = maiorDeIdade(idade);
if (verificacaoo)
{
    console.log("É maior de idade");
}
else
{
    console.log("É menor de idade");
}