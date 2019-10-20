using ClassAndMethodsAbstractExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstractExercise.Models
{
    public abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public TipoContribuinte TipoPessoa { get; set; }

        protected Contribuinte(string nome, double rendaAnual, TipoContribuinte tipoPessoa)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            TipoPessoa = tipoPessoa;
        }

        public abstract double ImpostoAPagar();
    }
}
