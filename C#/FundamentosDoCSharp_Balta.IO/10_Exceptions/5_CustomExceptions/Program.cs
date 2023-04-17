using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            var arr = new int[3];

            try
            {
                //for(var index = 0; index < 10; index++)
                //{
                //    Console.WriteLine(arr[index]);
                //}

                Cadastrar("");
            }
            //Sempre do mais específico ao mais genérico
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Não encontrei o índice na lista");
            //}
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }
            catch(MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        private static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            {
                //Mais genérico
                //throw new Exception("O texto não pode ser nulo ou vazio");

                //Mais específico
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
    }
}