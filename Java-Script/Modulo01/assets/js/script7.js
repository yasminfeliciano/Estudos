//Primeiro vem sua condição e um ponto de interrogação para verificar se é 'true' ou 'false', depois vem a condição se for 'true', depois dois pontos, e por fim sua condição caso seja 'false'.

//Aqui vamos definir o valor que um usuário vai pagar no frete caso ele seja membro ou não.
let isMember = true;
let shipping = (isMember? 2 : 10);
console.log("Frete: "+ shipping);

//Aqui verificamos se a pessoa é adulta ou não.
let age = 90;
let isAdult = (age >= 18 ? 'Sim':'Não');
console.log (isAdult);

//O switch funciona quase como o 'if' e serve é para ser usado quando você tem muitas condicionais a serem verificadas
let profession = "fiscal";
switch (profession)
{
    case 'fiscal':
        console.log("Sua camisa será VERDE");
    break;
    case 'bombeiro':
        console.log("Sua camisa será VERMELHA");
    break;
    case 'policial':
        console.log("Sua camisa será AZUL");
    break;
    default:    //O 'defaut'(padrão) é uma condicional para quando nenhuma outra for satisfeita como o 'else' sozinho, que funciona caso 'if' não seja satisfeito.
        console.log("Sua camisa será PRETA");
    break;
}