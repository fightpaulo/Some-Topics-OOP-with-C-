using ClassAndMethodsAbstractExercise.Models;
using ClassAndMethodsAbstractExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstractExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            Console.Write("Números de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Pessoa Física ou Pessoa Jurídica (PF/PJ): ");
                TipoContribuinte tipoContribuinte = (TipoContribuinte)Enum.Parse(typeof(TipoContribuinte), Console.ReadLine(), true);

                Console.WriteLine();

                Console.WriteLine($"Dados #{i + 1} contribuinte:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipoContribuinte)
                {
                    case TipoContribuinte.PF:
                        Console.Write("Gastos com saúde: ");
                        double gastosSaude = double.Parse(Console.ReadLine());
                        contribuintes.Add(new PessoaFisica(nome, rendaAnual, TipoContribuinte.PF, gastosSaude));
                        break;

                    case TipoContribuinte.PJ:
                        Console.Write("Números de Funcionários: ");
                        int numeroFunc = int.Parse(Console.ReadLine());
                        contribuintes.Add(new PessoaJuridica(nome, rendaAnual, TipoContribuinte.PJ, numeroFunc));
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Impostos pagos:");
            
            foreach (Contribuinte c in contribuintes)
            {
                Console.WriteLine($"{c.Nome} - R$ {c.ImpostoAPagar()}");
            }

            Console.ReadKey();
        }
    }
}
