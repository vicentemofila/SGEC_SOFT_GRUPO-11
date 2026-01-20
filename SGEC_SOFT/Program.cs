using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEC_SOFT
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         \n=== SISTEMA DE GESTÃO DE ESTUDANTES CARENCIADOS ===");

            Console.Write("\t\t\n                   DADOS PESSOAIS\n\n");
            Console.Write("Nome Completo: ");
            string nome = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();

            Console.Write("BI: ");
            string bi = Console.ReadLine();

            Console.Write("Telefone Principal: ");
            string telefone = Console.ReadLine();

            Console.Write("Nacionalidade: ");
            string nacionalidade = Console.ReadLine();

            Console.Write("Naturalidade: ");
            string naturalidade = Console.ReadLine();

            Console.Write("Pai: ");
            string pai = Console.ReadLine();

            Console.Write("Mãe: ");
            string mae = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.Clear();
            Console.Write("\t\t\n        FORMAÇÃO CONCLUIDA \n\n");
            Console.Write("Instituição de Formação: ");
            string instFormacao = Console.ReadLine();

            Console.Write("Curso de Formação: ");
            string cursoFormacao = Console.ReadLine();

            Console.Write("Nível Académico: ");
            string nivelFormacao = Console.ReadLine();

            Console.Write("Ano de Ingresso: ");
            int anoIngressoForm = int.Parse(Console.ReadLine());

            Console.Write("Ano de Conclusão: ");
            int anoConclusaoForm = int.Parse(Console.ReadLine());

            Console.Write("Média de Conclusão: ");
            double media = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("\t\t\n                   DADOS DA CANDIDATURA\n\n");
            Console.Write("Instituição de Candidatura: ");
            string instCand = Console.ReadLine();

            Console.Write("Curso de Candidatura: ");
            string cursoCand = Console.ReadLine();

            Console.Write("Nível Académico: ");
            string nivelCand = Console.ReadLine();

            Console.Write("Ano de Ingresso: ");
            int anoIngressoCand = int.Parse(Console.ReadLine());

            Console.Write("Ano de Frequência: ");
            int anoFreqCand = int.Parse(Console.ReadLine());

            Console.Write("Tipo de Bolsa (Integral/Parcial): ");
            string tipoBolsa = Console.ReadLine();

            EstudanteBolseiro estudante = new EstudanteBolseiro(nome, dataNascimento, sexo, bi, telefone, nacionalidade, naturalidade, pai, mae, endereco,
                                                               instFormacao, cursoFormacao, nivelFormacao, anoIngressoForm, anoConclusaoForm, media,
                                                               instCand, cursoCand, nivelCand, anoIngressoCand, anoFreqCand, tipoBolsa);

            Console.Clear();
            Console.Write("\t\t\n                   INFORMAÇÕES DO ESTUDANTE\n\n");
            estudante.MostrarInfo();

            GravacaoDados.SalvarEstudante(estudante);

            Console.WriteLine("\nClica em qualquer tecla para sair!");
            Console.ReadKey();
        }
    }

}
