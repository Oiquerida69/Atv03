using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string criador = "Wendell";
            // (String) = variavel tipo texto
            // "criador" = nome atribuido a variavel
            // "wendell" = dado dentro da variavel
            // "=" receptor do valor
            int idade = 22;
            float dinheiro = 2.50f;
            int soma = 78 + 192;
            float peso = 64.0f;
            float altura = 1,70f;
            float imc = peso / (altura * altura);
            Console.WriteLine("Meu nome é " + criador +
                " e eu tenho " + idade + " anos");
            
            Console.WriteLine($"eu tenho {peso} kg e {altura} cm e o meu imc")
            Console.WriteLine($"meu nome é {criador} e eu tenho {idade} anos ");
            Console.WriteLine("Minha idade é " + idade);
            Console.WriteLine("Aula 03 - Variaveis");
            Console.WriteLine("Programa Criado Por " + criador);// juntar dois textos se chama concatenação
            Console.WriteLine(  "Eu sou o " + criador);
            Console.WriteLine("Lembrando quem fez foi o " + criador);
            Console.WriteLine($"eu tenho {dinheiro} reais ");
            Console.WriteLine($"o resultado é {soma}");
            Console.ReadKey();

        }
    }
}
