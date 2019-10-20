using ClassAndMethodsAbstractExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstractExercise.Models
{
    public class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, TipoContribuinte tipoPessoa, double gastosSaude)
            :base(nome, rendaAnual, tipoPessoa)
        {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoAPagar()
        {
            double porcentagemImposto = GetPorcentagemImposto();
            double porcentagemGastosSaude = GetPorcentagemGastosSaude();

            return (RendaAnual * porcentagemImposto) - (GastosSaude * porcentagemGastosSaude);
        }

        private double GetPorcentagemImposto()
        {
            double porcentagemImposto = 0.0;

            if (RendaAnual < 20_000)
                porcentagemImposto = 0.15;
            else
                porcentagemImposto = 0.25;

            return porcentagemImposto;
        }

        private double GetPorcentagemGastosSaude()
        {
            double porcentagemGastosSaude = 0.0;

            if (GastosSaude > 0)
                porcentagemGastosSaude = 0.5;

            return porcentagemGastosSaude;
        }
    }
}
