function somar(x, y)
{
    return x + y;
}
console.log(somar(10, 5));

// Arrow function é uma função que pode ser feita dentro de uma variável.
const somarr = (x, y) =>
{
    return x + y;
} 
console.log(somarr(10, 5));

//Ela pode ser ainda mais resumida. Nesse caso não precisa de 'return' nem chaves, já que tem somente uma linha.
const somarrr = (x, y) => x + y;
console.log(somarrr(10, 5));

//Outro exemplo, agora com sobrenome
function sobrenome(sob)
{
    return 'Bonieky '+ sob;
}
console.log(sobrenome('Lacerda'));

//Funções com uma variável apenas não precisa colocar parêntese, mas por padronização vamos colocar "(sob)".
//Agora resumida
const sobrenomee = (sob) => 'Bonieky '+ sob;
console.log(sobrenomee('Lacerda'));