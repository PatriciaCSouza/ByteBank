using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(cpf)
        {
            Console.Write("Inserindo Diretor");
        }

        //quando se tem um processamento, ou seja, uma operação ou lógica a se fazer é melhor criar um método
        //como ele chama a mesma função que a classe funcionario, mas com um comportamento diferente, ele precisa sobreescrever o método do Funcionario
        //com o override aqui ele não é considerado um método, e sim uma sobreescrita do método do Funcionario
        public override double GetBonificacao()
        {
            //base quer dizer que o método que ele está chamando é o pertencente á classe Funcionario
            return Salario + base.GetBonificacao();
        }
    }
}
