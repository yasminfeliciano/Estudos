using System;

class Aula05
{
    static void Main()
    {
        int res = 10+5*2;
        Console.WriteLine(res);
        
        bool res2 = 10<5;
        Console.WriteLine(res2);
        
        int num = 10;
        num++; //num+=1; //num = num+1;
        num2+=2; //num = num+2;
        Console.WriteLine(num);
        
        // & = AND / E (FALSE  se pelo menos uma for falsa, TRUE se as duas forem verdadeiras)
        // | = OR / OU (TRUE se pelo menos uma for verdadeira, FALSE se as duas forem falsas)
        bool resOu = (5>3)|(10<5);
        Console.WriteLine(resOu);
    }
}