/*Calcule a porcentagem entre dois números. Exemplo: 25% de 40 é 10
Fórmula da porcentagem: (y / x) * 100
Uso da função:
let x = 40;
let y = 10;
let pct = calcPct(x, y);
console.log(`${pct}% de ${x} é ${y}`);*/

function calcPct(n1, n2)
{
    let pct = (n2 / n1) * 100;
    return pct;
    /* Ou simplesmente:
    return (n1 / n2)* 100; */
}

let x = 50;
let y = 10;
let pct  = calcPct(x, y);
console.log(`${pct}% de ${x} é ${y}`);



/* Calcule o preço do imóvel
- m2 = 3.000
- Se tiver 1 quarto, o m2 é 1x
- Se tiver 2 quarto, o m2 é 1.2x
- Se tiver 3 quarto, o m2 é 1.5x
Uso da função:
 */

function calcularImovel(metragem, quartos)
{
    let m2 = 3000;
    preco = 0
    switch(quartos)
    {
        case 1:
        default:
            preco = metragem*m2;
            break;
        case 2:
            preco = metragem * (m2 * 1.2);
            break;
        case 3:
            preco = metragem * (m2 * 1.5);
            break;
    }
    return preco;
}

let metragem = 123;
let quartos = 2;
let preco = calcularImovel(metragem, quartos);
console.log(`A casa custa R$ ${preco}`);



/* Crie uma função que valide usuário e senha.
Usuário correto: pedro
Senha correta: 123*/
 
//Uso da função:
function validar(usuario, senha)
{
    if(usuario ==="pedro" && senha === 123)
    {
        return true;
    }
    else
    {
        return false;
    }
}

let usuario = "Bonieky";
let senha = "1234";

let validacao = validar(usuario, senha);
if(validacao)
{
    console.log("Acesso concedido.");
}
else
{
    console.log("Acesso NEGADO!");
}