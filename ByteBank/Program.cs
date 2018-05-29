using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("43.432.432-09");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("321.321.322-09");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Console.WriteLine("Bonificação de uma referencia de diretor" + roberta.GetBonificacao());

            //Isso é polimorfismo colocar em uma variavel base um objeto especializado
            //Com esse polimorfismo, estamos criando um novo funcionario do tipo Diretor
            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionário: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
