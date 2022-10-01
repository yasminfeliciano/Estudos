let dia = 3;
let diaNome = '';

switch(dia){
    case 1:
        diaNome = 'Segunda-Feira';
        break;
    case 2:
        diaNome = 'Terça-Feira';
        break;
    case 3:
        diaNome = 'Quarta-Feira';
        break;
    case 4:
        diaNome = 'Quinta-Feira';
        break;
    case 5:
        diaNome = 'Sexta-Feira';
        break;
    case 6:
        diaNome = 'Sábado';
        break;
    case 7:
        diaNome = 'Domingo';
        break;
}

document.getElementById("dia").innerHTML = "Hoje é: "+diaNome;

let diaFDS = 5;
let diaNomeFDS = '';

switch(diaFDS){
    case 6: //caso 6 ou 7
    case 7:
        diaNomeFDS = 'Final de Semana';
        break;
    default:
        diaNomeFDS = 'Dia de Semana';
        break;
}