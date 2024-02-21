using System.Security.Claims;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade ;

            Console.WriteLine("digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("digite o sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine("nome: {0} " , nome );
            Console.WriteLine("idade: {0} anos", idade);
            Console.WriteLine("cidade: {0} ", cidade);
            //Console.WriteLine("nome: {0} \n idade: {1} anos \n cidade: {2}",nome, idade, cidade);
        }
        int n1
        int n2;

        Console.writeline("digite um numero qualquer",n1);
            n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite um outro numero qualquer",n2);
           n2 = int.Parse(Console.ReadLine());
    }


    
}
