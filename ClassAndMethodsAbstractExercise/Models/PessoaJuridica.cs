using ClassAndMethodsAbstractExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstractExercise.Models
{
    public class PessoaJuridica : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, TipoContribuinte tipoPessoa, int numeroFuncionarios)
            :base(nome, rendaAnual, tipoPessoa)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoAPagar()
        {
            double porcentagemImposto = GetPorcentagemImposto();

            return RendaAnual * porcentagemImposto;
        }

        private double GetPorcentagemImposto()
        {
            double porcentagemImposto = 0.0;

            if (NumeroFuncionarios > 10)
                porcentagemImposto = 0.14;
            else
                porcentagemImposto = 0.16;

            return porcentagemImposto;
        }
    }
}
