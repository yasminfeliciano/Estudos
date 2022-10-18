//INTERVALOS
//Para exibir o horário atual na tela e desativar o relógio.
let timer;

function comecar(){
    timer = setInterval(showTime, 1000);
}

function parar(){
    clearInterval(timer);    
}

function showTime() {
    let d = new Date();
    let h = d.getHours();
    let m = d.getMinutes();
    let s = d.getSeconds();
    let txt = h+":"+m+":"+s;

    document.querySelector('.demo').innerHTML = txt;
}

//Executar uma fuunção em um determinado tempo.
let timerRodou;
function rodar(){
    timerRodou = setTimeout(function(){
        alert("Rodou!");
        document.querySelector(".demo2").innerHTML = 'Rodou!';
    }, 2000);
}

function pararRodou(){
    clearTimeout(timerRodou);
}

//TEMPLATE STRINGS
let nomeStrings = 'Bonieky';

let idadeStrings = 90;

let fraseStrings = 'Meu nome é '+nomeStrings+', eu tenho '+idadeStrings+' anos e ano que vem eu farei '+(idadeStrings+1)+' anos';

let frase2Strings = `Meu nome é ${nomeStrings}, eu tenho ${idadeStrings} anos e ano que vem eu farei ${idadeStrings+1} anos`;

console.log(fraseStrings);

console.log(frase2Strings);

//DESCONSTRUINDO OBJETOS
let pessoaObj = {
    nomeObj: 'Bonieky',
    sobrenomeObj: 'Lacerda',
    idadeObj: 90,
    socialObj: {
        facebookObj: 'facebook@b7web',
        instagramObj: {
            urlObj:'instagram@bonieky',
            seguidoresObj: 1000
        }
    },
    nomeCompletoObj: function(){
        return `${this.nomeObj} ${this.sobrenomeObj}`;
    }
}

//Dados completos do objeto.
console.log(pessoaObj);

//Para exibir os dados pessoais.
/*
let nomeObj =  pessoaObj.nomeObj;
let sobrenomeObj = pessoaObj.sobrenomeObj;
let idadeObj = pessoaObj.idadeObj;

console.log(nomeObj, sobrenomeObj, idadeObj);
*/

//Vamos desconstruir o objeto transformando eles em variáveis independentes. Para alterar bo nome de uma variável, basta colocar ':' e em seguida o novo nome da variável. Quando no objeto não existir uma variável que você queira acrescentar, é só utilizar '=' e em seguida um valor, que será definido como o valor padrão da variável, porém caso a variável exista no objeto, então será validado o valor original e a variável padrão não será aplicada;
let{nomeObj:nomeNovoObj, sobrenomeObj, idadeObj, enderecoObj = 'casa 3 da rua 5'} = pessoaObj;

console.log(nomeNovoObj, sobrenomeObj, idadeObj, enderecoObj);

//Para pegar informações complexas dentro do objeto.
let{nomeObj, socialObj:{instagramObj:{urlObj:instagramObj, seguidoresObj}}} = pessoaObj;

console.log(nomeNovoObj, instagramObj, seguidoresObj);

//Para funções.
function pegarNomeCompletoObj(obj){
    return obj.nomeObj+' '+obj.sobrenomeObj;
    //Ou então da outra forma.
    //return `${nomeObj} ${sobrenomeObj}`
}

console.log(pegarNomeCompletoObj(pessoaObj));

//Também dá pra desconstruir dentro do parâmetro da função.
function pegarNomeCompletoObj2({nomeObj, sobrenomeObj, socialObj:{instagramObj:{urlObj:instagramObj}}}){
    return `${nomeObj} ${sobrenomeObj} {Siga em ${instagramObj}}`;
}

console.log(pegarNomeCompletoObj2(pessoaObj));