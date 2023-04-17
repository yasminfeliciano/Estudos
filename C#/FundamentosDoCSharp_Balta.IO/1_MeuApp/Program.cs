using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);
            
    /*  
        NOTAS IMPORTANTES
    - Não utilize espaços nem caracteres especiais na criação do programa
        Bons: MeuApp, Pedidos, MinhaApp
        Ruins: "Meu App", $APP, App #Teste
    - Tente utilizar caminhos curtos e sem caracteres especiais
        Bons: C:\dev, C:\apps
        Ruins: C:\Caminho Com Espaços e Caracteres Especiais\Meu App
    - Evite caminhos de rede
        Se possível, utilize O C:\
    - O C# é Code Sensitive
        Isto significa que ele diferencia maiúsculas de minúsculas
        Teste é diferente de teste

        ESCOPO DE UM PROGRAMA
    - Importações
    - Namespace
    - Classe
    - Método Principal

        NAMESPACE
    - Enquanto as pastas são as divisões físicas
    - Os namespaces são as divisões lógicas
    - Assim como não podemos ter dois arquivos com mesmo nome nas pastas
    - Não podemos ter duas classes com mesmo nome em um namespace
    - O ideal é ter apenas um namespace e uma classe por arquivo
    - O escopo de um namespace é definido entre CHAVES
        Classes e métodos também
    - Um namespace pode ser reutilizado
        Pode estar presente em diversos arquivos
    - Podemos criar quantos namespaces quisermos
    - Nao devem conter espacos ou caracteres especiais
    - Toda palavra no namespace comeca com maitisculo
    - Podemos ter um namespace dentro de outro usando "."
        namespace MeuApp.Teste
    - A importacao que vimos anteriormente é feita pelos namespaces
    - Normalmente acompanham os nomes das pastas
    - Durante a execucao, todos os arquivos do C# serao unificados
    - A divisao fisica se perdera
    - Sobrara apenas a divisdo logica, que sao os Namespaces

        USING
    - Importacões definem as bibliotecas que nosso programa ira utilizar
    - Por padrao só o basico vem incluso
    - Precisamos importar o que desejamos para poder trabalhar
    - Isto é feito no começo do programa
    - Utilizamos a palavra reservada using para isto
    - Organizar nosso código em pastas e namespaces é fundamental
    - Em aplicações grandes, o volume de código é alto
    - A quantidade de arquivos é alta
    - E o número de pessoas trabalhando no mesmo projeto também.
    - Entender bem esta organizacao é fundamental
    - Use e abuse da criacdo de arquivos e namespaces

        VARIÁVEIS
    - Uma variavel é algo que utilizamos para armazenar uma informação
    - Ser variavel significa que seu valor pode ser alterado a qualquer momento
    - Ou seja, ele pode variar
    - Sempre que “criamos” uma variavel, dizeros que estamos inicializando ela
    - Podemos usar um TIPO ou a palavra reservada var para criar uma variavel
    - Vamos aprender ainda sobre tipo de dados
    - No C# 0 tipo vem sempre antes do nome da variavel
    - Podemos informar um valor já na criação da variavel
    - Se nao informado o valor padrao sera aplicado
        int idade;          Correto inicia com ZERO
        int idade = 25;     Correto inicia com 25
        var idade = 25;     Correto inicia com 25
        var idade;          Errado
    - Utilize nomes coesos
    - Não utilize caracteres especiais ou espaços
    - Nao comece com numeros
    - A primeira letra de cada palavra é SEMPRE minuscula

        CONSTANTES
    - Também utilizamos uma constante para armazenar uma informação.
    - As constantes NAO PODEM ser alteradas
    - Uma vez criadas somos obrigados a atribuir um valor
    - Feito isto elas nado poderao ser modificadas novamente
    - Nao funcionam com a utilização de var
    - São mais otimizadas que as variáveis
    - Recomendadas para usos frequentes
    - A definição de constante é dada pela palavra reservada const antes do tipo
    - Caso nao seja informado um valor, o valor padrao sera atribuido
        const int IDADE_MINIMA;         Correto inicia com ZERO
        const int IDADE_MINIMA = 25;    Correto inicia com 25
        const var IDADE_MINIMA = 25;    Errado
        const var IDADE_MINIMA;         Errado
    - Utilize nomes coesos
    - Nao utilize caracteres especiais ou espaços
    - Nao comece com numeros
    - É comum vermos constantes todas em maiúsculas, separadas por “_”
    - A ideia é bater o olho no código e saber que aquilo é uma constante

        PALAVRAS RESERVADAS
    - Também chamados de keywords
    - São palavras de uso exclusivo do C#
    - Nao podemos utilizar como nomes de variaveis ou constantes
    - O Visual Studio Code vai te avisar sobre eles

abstract    bool        continue    decimal     default

event       explicit    extern      char        checked

class       const       break       as          base

delegate    is          lock        long        num

byte        case        catch       false       finally

fixed       float       for         as          foreach

goto        if          implicit    in          int

interface   intenal     do          double      else

namespace   new         null        object      operator

out         override    params      private     protected

public      readonly    sealed      short       sizeof

ref         return      sbyte       stackalloc  static 

string      struct      void        volatile    while

true        try         switch      this        throw

unchecked   unsafe      ushort      using       using static

virtual     typeof      uint        ulong       out (generic modifier)

add         alias       async       await       dynamic

from        get         orderby     ascending   descending

group       into        join        let         nameof

global      partial     set         remove      select

value       var         when        where       yield

        TIPOS PRIMITIVOS

    - Também conhecidos como built-in types
    - São tipos base cujo outros tipos (Complexos) irão derivar
    - Definir 0 tipo correto otimiza a execugao do programa
    - São chamados de Tipos de Valor
    - Armazenam o valor e nao a referência para um item na memoria
    - Sao classificados em
        Tipos Simples (Simple Types)
        Enumeradores (Enums)
        Estruturas (Structs)
        Tipos Nulos (Nullable Types)
    - Cada tipo possui uma capacidade
    - Caso esta capacidade exceda, o programa gera um erro
    - Esta capacidade pré-definida ajuda na otimizacao do seu programa
    - Por exemplo o int que usamos previamente:
        -2,147,483,648 até 2,147,483,647

        SYSTEM
    - No .NET tudo começa de um tipo base chamado system
    - Todo e qualquer tipo, seja built-in ou complexo deriva dele
    - Ele é a base de todos os objetos no .NET
    - Nao precisamos nos preocupar em usa-lo ou qualquer coisa similar
    -Seu uso ja é implicito

        BYTE
    - O tipo byte é utilizado para representar um byte de fato
    - Em diversos casos precisamos da cadeia de bytes de um arquivo por exemplo
    - Também chamado de byte array
    - Temos também o sbyte, que permite valores negativos
    - Signed e Usigned - Valores com sinal como “-" por exemplo, sAo chamados de signed.
    - byte (8-bit)
        O até 255
    - sbyte (8-bit)
        -128 até 127
    - Note que o sbyte permite valores negativos, por isto no nome sbyte, que significa Signed Byte

        NÚMEROS INTEIROS
    - Numeros inteiros, ou seja, sem pontuacao, podem ser definidos pelos tipos
        short/ushort
        int/uint
        long/ulong
    - Assim como temos o signed nos bytes, nos numeros por padrao são permitidos valores negativos
    - Então usamos o unsigned para definir que o mesmo nao pode receber valores negativos
    - O tipo int é o mais comum a ser encontrado
    - Tamanhos:
        short (16-bit) (-32,768 to 32,767)
        ushort (16-bit) (O até 65.535)
        int (32-bit) (-2,147,483,648 até 2,147,483,647)
        uint (32-bit) (O até 4,294,967,295)
        long (64-bit) (-9,223,372,036,854,775,808 até 9,223,372,036,854,775,807)
        ulong (64-bit) (O até 18,446,744,073,709,551,615)

        NÚMEROS REAIS
    - Numeros que exigem uma maior precisão, ou seja, com pontuaçao
    - float (Notacdo F)
    - double
    - decimal (Notagao M)
    - Possuem assimilacdo negativa e positiva por padrao dispensando uso do signed/unsigned em seus tipos.
    - float (32-bit)
        -3,402823e38 até 3.402823e38
    - double (64-bit)
        -1.79769313486232e308 até 1.79769313486232e308
    - decimal (128-bit)
        (+0U-)1.O x 10e-28 até 7.9 x 10e28

        Boolean
    - Tipo booliano, armazena apenas true ou false (Verdadeiro ou Falso)
    - Definido pela palavra reservada bool
    - bool (8-bit)
        true ou false

        CHAR
    - Utilizado para armazenar apenas um caractere no formato Unicode
    - Definido pela palavra reservada char
    - A atribuição de um valor char é dada por aspas simples
    - char (16-bit)
        Qualquer caractere

        STRING
    - Armazena uma cadeia de caracteres
    - Podemos pensar nele como uma lista de char
    - Definido pela palavra reservada string
    - Aatribui¢gao de um valor string é dada por aspas duplas
    - string (?)
        Uma cadeia de caracteres

        VAR
    - Substitui o nome de um tipo
    - Sera do tipo do primeiro valor atribuido
    - Recomendado o uso
    - Deixe para usar var quando já dominar os tipos
    var idade = 25; Será do tipo int
    var nome = “André”; Será do tipo string        

        OBJECT
    - Tipo genérico que recebe qualquer valor ou objeto

    - Caso nao saiba o tipo da informacao ou ela seja de varios tipos diferentes
    - Não possui intelisense (Ajuda dos editores) por ser um tipo desconhecido.
    - Evite usar
    object idade = 25; // Será do tipo object
    object nome = “André”; // Será do tipo object

        NULLABLE TYPES
    - Significa vazio, nada
    - Diferente de zero ou uma string vazia
    - Todo tipo, primitivo ou complexo pode receber o valor null
    - O tipo deve ser marcado como Nullable Type
    - Podemos atribuir null a um objeto
    - Desde que o mesmo seja marcado como nullable
        Usando interrogagao na frente do tipo
    - Se uma chamada a um valor nulo for feita um erro sera apresentado
    int? idade = null;

        ALIAS
    - Alias é um apelido que todo tipo no NET tem
    - Por exemplo
        System.String tem o alias string
        Vimos anteriormente os alias
    - Como o C# é Case Sensitive, tanto faz escrevermos um ou outro
    - Porém,o recomendado é sempre usar o alias
    - No caso abaixo o resultado é o mesmo
        Com alias escrevemos menos
    int idade = 25; Alias
    Int32 idade = 25; Tipo

        VALORES PADRÕES
    - Todo tipo built-in, jÁ possui um valor padrao
    - Se nenhum valor for informado, seu valor padrao sera utilizado
    - int=>0
    - float => 0
    - decimal => 0
    - bool => false
    - char => '\0'
    - String =>""

        CONVERSÃO IMPLÍCITA
    - É comum precisarmos transformar um dado de tipo X para tipo Y
    - Existem dois tipos de conversao, as implicitas e as explicitas
    - As implicitas sdo conversões que
    - Podem ser executadas apenas com passagem de dados
    - Possuem tipos compativeis
        float valor = 25.8F;
        int outro = 25;
        valor = outro; Conversão implícita
    - A conversao anterior ocorreu pois um numero real pode receber um numero inteiro
    - Porém, ao contrario nao aconteceria
        Um numero inteiro nao tem pontuagao
        Logo ele nao poderia receber um numero real
    - A conversao so ocorrera se
        O tipo de dado for compativel
        O tamanho do dado for compativel
    - Em caso de numeros a precisao pode ser alterada
    - Qualquer situação adversa causara erro
    - sbyte
        short, int, long, float, double, decimal
    - byte
        short, ushort, int, uint, long, ulong, float, double, decimal
    - short
        int, long, float, double, or decimal
    - ushort
        int, uint, long, ulong, float, double, or decimal
    - int
        long, float, double, or decimal.
    - uint
        long, ulong, float, double, or decimal
    - long
        float, double, or decimal
    - ulong
        float, double, or decimal
    - char
        ushort, int, uint, long, ulong, float, double, or decimal
    - float
        double

        CONVERSÃO EXPLÍCITA
    - Ocorre quando os tipos nao sao compativeis
    - É dada pelo uso do tipo entre parênteses antes da atribuicao
    - Segue as mesmas regras anteriores
    int inteiro = 100;
    uint inteiroSemSinal = (uint)inteiro; // Conversão explícita

        PARSE
    - Método presente em todo tipo primitivo
    - Usado para converter um caractere ou string para um tipo qualquer
    - Caso haja alguma incompatibilidade, gera um erro
    int inteiro = int.Parse("100") ;

        CONVERT
    - Similar ao parse visto anteriormente
    - Porém permite converter varios tipos de valor
        Não apenas string
    - Devemos informar o tipo na chamada da conversao
    int inteiro = Convert.ToInt32("100") ;
    
        CONVERTENDO TIPOS
    "
        int inteiro = 100;
        float real = 25.8f;

        real = inteiro; conversão implícita
        inteiro = (int)real; conversão explícita
        inteiro = int.Parse(real.ToString()); convertendo real para string e depois para int
        inteiro = Convert.ToInt32(real); conversão de número real para inteiro, arredondamento
        Convert.ToBoolean(1); conversão de 0 = false, número>0 = true
        Convert.ToBoolean("true); conversão de string para boolean
    "

        OPERADORES ARITMÉTICOS
    - Soma (+)
    - Subtragao (-):
    - Multiplicacao (*)
    - Divisdo (/)
    - Multiplicação e divisão sao executadas primeiro
    - Caso queira executar em outra ordem, usar parênteses
    - Aceita short, int, float, double e decimal
    - Em caso de uso de numeros inteiros
        Se o valor for real, sera arredondado
        4.4 => 5

    int soma = 25 + 22; 47
    int subtracao = 25 - 22; 3
    int divisao = 25 * 22; 550
    int multiplicacao = 22 / 5; 4 (foi arredondado)

    - Utilizamos parênteses para redefinir a ordem de execução
    int x = 2 + 2 * 2; 6
    int y = 2 + (2 * 2); 6 mesmo do anterior
    int z = (2 + 2) * 2; 8 executou a soma primeiro

        OPERADORES DE ATRIBUIÇÃO
    - Utilizamos igual para atribuir um valor
    - Porém, podemos utilizar igual junto a um operador aritmético
    - x += 5 é o mesmo que x = x + 5

    int x = 0;  Atribuição
    x += 5;     x = x + 5;
    x -= 1;     x = x - 1;
    x *= 10;    x = x * 10;
    x /= 2;     x = x / 2;

        OPERADORES DE COMPARAÇÃO
    - Podemos comparar qualquer tipo de dado
        Numeros, strings, bytes
    - A comparacão SEMPRE retorna verdadeiro ou falso
        True ou False
    - Igual ==
    - Diferente !=
    - Maior que >
    - Menor que <
    - Maior ou igual a >=
    - Menor ou igual que <=

    int x = 25;
    x == 0; False
    x != 0; True
    x > 0; True
    x < 0; False
    x <= 0; False
    x >= 0; True

        OPERADORES LÓGICOS
    - Usado para operações condicionais
    - Retorna SEMPRE verdadeiro ou falso
    - E-and (&&)
        Deve atenter TODAS as condições.
    - OU-or(||)
        Se atender uma condição já retorna verdadeiro
    - NEGACAO-not (!)
    
    int x = 12;
    bool entre = (x > 25) & (x < 40); false
    bool ou = (x > 25) || (x < 40); true
    bool negacao = !(x < 25); false

        OPERADOR CONDICIONAL: IF
    - Tradução: "SE" ou seja, “caso alguma condição seja atendida”
    - Utilizado para tomada de decisões
    - Utiliza os operadores lógicos
    - Complemento ao if (else)
    - Caso a condição nao seja atendida
    - Podemos ter
        else if(condição)
        Não tem limites (Mas cuidado)
    - Podemos ter apenas else para executar algo caso a condição seja atendida
    - Somente if:
        if(condição) { // Caso seja verdadeiro}
        
        if(condição) // Caso seja verdadeiro
        ... // Caso só haja uma linha, não precisa de chaves
    - if e else:
        if(condicao) { // Caso seja verdadeiro}
        else { // Caso seja falso}

        if(condicao) // Caso seja verdadeiro
        ... // Caso só haja uma linha, não precisa de chaves
        else // Caso seja falso
    - Mais de 1 else:
        if(condição) { // Caso seja verdadeiro}
        else if (condição) { // Senão, testa outra condição }
        else if (condição) { // Senão, testa outra condição }
        else { // Se não acontecer nenhuma das anteriores }

        ESTRUTURA CONDICIONAL: SWITCH
    - Utilizado quando temos muitas decisões
    - Executado em cascata
    - Devemos parar manualmente a execução com o comando break
    - Possui uma execução padrão chamada default

    int valor = 1;
    switch (valor)
    {
    case 1: Console.WriteLine("1"); break;
    case 2: Console.WriteLine("2"); break;
    case 3: Console.WriteLine("3"); break;
    default: Console.WriteLine("4"); break; // Se não for 1, 2 ou 3

        LAÇOS DE REPETIÇÃO: FOR
    - Tradução “para”, ou seja, para cada item em um valor.
    - Executa uma determinada ação várias vezes
    - Definido pela palavra for
    - Exige 3 parâmetros
        Contador
        Condição
        Incremento

    - Conta de 0 a 5
    for (var i = 0; i <= 5; i++)
    Console.WriteLine(i);

    - Conta de 1 a 5
    for (var i = 1; i <= 5; i++)
    Console.WriteLine(i);

    - Conta de 0 a 4
    for (var i = 0; i < 5; i++)
    Console.WriteLine(i);

    - Conta de 5 a 0
    for War i = a) f= 8)
    Console.WriteLine(i) 5;

        LAÇOS DE REPETIÇÃO WHILE
    - Tradugao: “Enquanto", ou seja, enquanto uma condição for verdadeira
    - Definido pela palavra while
    - Exige apenas uma condição,
    - Checa a condição ANTES de executar

    var valor = 0;
    //Conta de 0 a 5
    //Exibe de 0 a 5 na tela
    while (valor <= 5)
    {
        Console.WriteLine(valor);
        valor++;
    }

    valor = 0;
    //Conta de 0 a 5
    //Exibe de 1 a 6 na tela
    while (valor <= 5)
    {
        valor++;
        Console.WriteLine(valor);
    }

        LAÇOS DE REPETIÇÃO: DO/wHILE
    - Tradução: "Faca", ou seja, realiza uma ação enquanto.
    - Definido pela palavra do/while
    - Exige apenas uma condição no while
    - Checa a condição DEPOIS de executar
    
    var valor = 0;
    do
    {
        Console.WriteLine("Teste") ;
        valor++;
    } while (valor < 5);

        MÉTODOS E FUNÇÕES
    - Podemos segmentar nosso programa em funções
    - Também conhecidos como métodos
    - O main é um exemplo de método
    - Possui um retorno, um nome e parâmetros
    - Esta composição é chamada de assinatura
    - Começam sempre com maiuscula
    
    static void Main(string[] args)
    {
        // Invocagéo do método
        MeuMetodo("C# é legal!");
    }

    // Definicaéo do método
    static void MeuMetodo(string parametro)
    {
        Console.WriteLine(parametro);
    }

    //Definição do método
    //Retorna uma string e recebe vários parâmetros
    static string RetornaNome(string nome, string sobrenome)
    {
        // Retorna o nome e sobrenome
        return nome + " " + sobrenome;
    }

    static void Main(string[] args)
    {
        //Invocação do método
        //Armazena o resultado em uma variável
        var nome = RetornaNome("André", "Baltieri");
        //Imprime o nome na tela
        Console.WriteLine(nome);
    }
    
        VALUE TYPES E REFERENCE TYPES
    - A memória é dividida em duas partes, Heap e Stack
    - Heap armazena os dados
    - Stack armazena as referências para os dados

        Value Types:
    - Qualquer tipo no .NET é tratado como
        Tipo de Referência (Reference Type)
        Tipo de Valor (Value Type)
    - Tipos de valor armazenam dados
    - São armazenados em um local da memória chamada Stack
    - Quando armazenamos um valor, a memória é alocada
    - Este espaço armazena o dado criado
    - Nossa variável acessa este dado diretamente
    - Se assimilarmmos uma variável do tipo de valor a outra
        O valor será COPIADO
        Ambas serão independentes
    - Built-in, Structs, Enums
    - Garbage Collector não acessa o Stack

    int x = 25;
    int y = x; //Y é uma cópia de X
    Console.WriteLine(x); //25
    Console.WriteLine(y); //25
    x = 32; //Somente X foi alterado
    Console.WriteLine(x); //32
    Console.WriteLine(x); //25

        Reference types:
    - Armazenam o endereço do objeto que contém os dados.
    - Nao armazena os dados em si
    - São armazenados em um local da memória chamado de Heap
    - Ao assimilar uma variável
        Criará uma referência
        Aponta para a mesma informação
        Não são independentes
    - Quando não mais utilizados são marcados para exclusão
    - Garbage Collector passa removendo todos eles
    - Classes, Objects, Arrays...

    var arr = new string[2];
    arr[0] = "Item 1";
    var arr2 = arr; //Não cria uma cópia

    Console.WriteLine(arr[0]);
    Console.WriteLine(arr2[0]);

    //Altera as duas listas
    arr[0] = "Item Alterado";
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr2[0]);

        STRUCTS
    - Tipos de dado estruturado
    - Apenas a estrutura, o esqueleto
    - Tipo de valor
    - Armazenam apenas outros tipos de dados
    - Definido pela palavra struct
    - Composto de propriedades e métodos
    - Nome sempre com maiusculo
        O mesmo para propriedades e métodos
    - Criado a partir da palavra new
        Neste momento sim temos os valores
    - A anatomia de uma estrutura normalmente é
    struct Product
    {
        //Propriedades

        //Métodos
    }

    - Anatomia de uma propriedade
    struct Product
    {
        //Propriedades
        public int Id;

        //Métodos
    }

    - Anatomia de um método
    struct Product
    {
        //Propriedades
        public int Id;
        public float Price;

        //Métodos
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }

    - Para criar uma estrutura
    static void Main(string[] args)
    {
        //Cria uma estrutura
        var product = new Product();
    }

    - Vem com dados dos tipos padrao
    - Para preencher os dados
    var product = new Product();
    product.Id = 1;
    product.Title = "Mouse gamer"; 
    product.Price = 197.23f;
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Title);
    Console.WriteLine(product.Price);

    - Método construtor é um método com mesmo nome da struct
    struct Product
    {
        public Product(int id, string title, float price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }

    - Eles facilitam a criacdo de estruturas
    var product = new Product(1, "Mouse Gamer", 128.75f);
    Console.WriteLine (product.Id) ;
    Console.WriteLine(product.Title) ;
    Console.WriteLine(product.Price) ;
    Console .WriteLine(product.PriceInDolar(5.70f));

    Exemplo:
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Será exibido as características definidas
            Product mouse = new Product(1, "Mouse gamer", 299.97);

            //Será exibido 0(int), nulo(string), 0(double)
            Product mouse2 = new Product();

            //Será atribuida um novo valor para o Id
            mouse.Id = 55;

            //mouse sendo exibido
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);

            //mouse2 sendo exibido
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product
    {
        //construtor
        public Product(int id, string name, double price)
        {
            //Propriedade=parametro
            Id = id;
            Name = name;
            Price = price;
        }

        //Propriedades
        public int Id;
        public string Name;
        public double Price;

        //Método
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}

        ENUMERADORES
    - Usado para fornecer uma melhor visualização do código
    - Substituem o uso de inteiros
    - Usados em listas curtas
    - Usados em dados fixos
        Hard Coded
    - Sempre em maiúsculo
        Começar com a letra E
    - Anatomia de um enumerador:
    enum EEstadoCivil
    {
        //Enumeradores
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }
    - Uso de um enumerador
    struct Client
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;
    }
    // Sem enumeradores
    var cliente = new Cliente("João Silva", 1);
    // Com enumerador
    var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
    - Exibindo dados de um enumerador
    Console.WriteLine(cliente.Nome);
    Console.WriteLine(cliente.EstadoCivil); //Escreve Casado
    Console.WriteLine((int)cliente.EstadoCivil); //Escreve 2
    - Exemplo de uso:
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Será exibido as características definidas
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);

            //Será exibido 0(int), nulo(string), 0(double), nulo(EProductType)
            var mouse2 = new Product();

            //Será atribuida um novo valor para o Id
            mouse.Id = 55;

            //mouse sendo exibido
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.writeLine(mouse.Type);

            //mouse2 sendo exibido
            Console.WriteLine(mouse2.Id);
            Console.WriteLine(mouse2.Name);
            Console.WriteLine(mouse2.Price);
            Console.WriteLine(mouse2.Type)
        }
    }
    struct Product
    {
        //construtor
        public Product(int id, string name, double price, EProductType type)
        {
            //Propriedade=parametro
            Id = id;
            Name = name;
            Price = price;
            Type = type; //Propriedade enum

        }

        //Propriedades
        public int Id;
        public string Name;
        public double Price;
        public EProductType type; //Propriedade enum

        //Método
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}




    

 


 




    */
        }
    }
}