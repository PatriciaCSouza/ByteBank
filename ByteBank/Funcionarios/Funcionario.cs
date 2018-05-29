using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        //quer dizer que o cpf é obrigatório para a criação de um novo funcionario
        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        //quando se tem um processamento, ou seja, uma operação ou lógica a se fazer é melhor criar um método
        //virtual quer dizer que ele pode ter uma classe filha; uma classe derivada que pode mudar o comportamento desse método
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

    }
}
