//ARRAy
//Arrays são itens numerados.
let carrosArray = ['Palio', 'Uno', 'Corola', 'Ferrari'];

console.log(carrosArray[2]);

//Os arrays podem ter funções como um dos itens, porém nesse caso elas não devem ter nomes.
let carrosArray2 = [
    'Palio',
    'Uno',
    'Corola',
    'Ferrari',
    function(){
       console.log('Testando 1, 2, 3...'); 
    }
] 

//Aqui estou chamando a função do array para ser executada
carrosArray2[4]();

//Exemplo de um array de arrays
let ingredientes = [
    ['uva', 'pera', 'maça'],
    ['arroz', 'macarrão']
];

console.log(ingredientes)

console.log(ingredientes[1][0]);



//OBJETOS
//Objetos são itens nomeados.
let carroObjeto = {
    nome: 'Fiat',
    modelo: 'Uno',
    peso: '800kg',
    ligado: false,
    ligar:function(){
        this.ligado = true;
        console.log("Ligando o "+this.modelo);
        console.log("VRUM VRUM!");
    },
    acelerar:function(){
        if(this.ligado==true){
            console.log("Riiiiiiiiihhhiii");
        }
        else{
            console.log(this.nome+" "+this.modelo+" não está ligado!");
        }
    }
};

console.log(carroObjeto['nome']);
//ou
console.log(carroObjeto.nome);

console.log("Modelo: " +carroObjeto.modelo);

carroObjeto.ligar();

carroObjeto.acelerar();

//Arrays também podem conter objetos
let carrosArray3 = [
    {nome:'Fiat', modelo:'Palio'},
    {nome:'Fiat', modelo:'Uno'},
    {nome:'Toyota', modelo:'Corolla'},
    {nome:'ferrari', modelo:'Spider'}
]

console.log(carrosArray3);

console.log(carrosArray3[2]);

console.log(carrosArray3[2].modelo);
//ou
console.log(carrosArray3[2]['modelo']);