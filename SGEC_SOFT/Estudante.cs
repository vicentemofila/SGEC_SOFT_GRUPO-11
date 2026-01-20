using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEC_SOFT
{

    public class Estudante
    {
        
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string BI { get; set; }
        public string TelefonePrincipal { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Endereco { get; set; }

        
        public string InstituicaoFormacao { get; set; }
        public string CursoFormacao { get; set; }
        public string NivelAcademicoFormacao { get; set; }
        public int AnoIngressoFormacao { get; set; }
        public int AnoConclusaoFormacao { get; set; }
        public double MediaConclusao { get; set; }

        
        public string InstituicaoCandidatura { get; set; }
        public string CursoCandidatura { get; set; }
        public string NivelAcademicoCandidatura { get; set; }
        public int AnoIngressoCandidatura { get; set; }
        public int AnoFrequenciaCandidatura { get; set; }

        public Estudante(string nomeCompleto, DateTime dataNascimento, string sexo, string bi, string telefonePrincipal, string nacionalidade, string naturalidade, string pai, string mae, string endereco,
                         string instituicaoFormacao, string cursoFormacao, string nivelAcademicoFormacao, int anoIngressoFormacao, int anoConclusaoFormacao, double mediaConclusao,
                         string instituicaoCandidatura, string cursoCandidatura, string nivelAcademicoCandidatura, int anoIngressoCandidatura, int anoFrequenciaCandidatura)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            BI = bi;
            TelefonePrincipal = telefonePrincipal;
            Nacionalidade = nacionalidade;
            Naturalidade = naturalidade;
            Pai = pai;
            Mae = mae;
            Endereco = endereco;

            InstituicaoFormacao = instituicaoFormacao;
            CursoFormacao = cursoFormacao;
            NivelAcademicoFormacao = nivelAcademicoFormacao;
            AnoIngressoFormacao = anoIngressoFormacao;
            AnoConclusaoFormacao = anoConclusaoFormacao;
            MediaConclusao = mediaConclusao;

            InstituicaoCandidatura = instituicaoCandidatura;
            CursoCandidatura = cursoCandidatura;
            NivelAcademicoCandidatura = nivelAcademicoCandidatura;
            AnoIngressoCandidatura = anoIngressoCandidatura;
            AnoFrequenciaCandidatura = anoFrequenciaCandidatura;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("         \n=== DADOS PESSOAIS ===");
            Console.WriteLine($"Nome Completo: {NomeCompleto}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"BI: {BI}");
            Console.WriteLine($"Telefone Principal: {TelefonePrincipal}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Naturalidade: {Naturalidade}");
            Console.WriteLine($"Pai: {Pai}");
            Console.WriteLine($"Mãe: {Mae}");
            Console.WriteLine($"Endereço: {Endereco}");

            Console.WriteLine("         \n=== FORMAÇÃO CONCLUIDA ===");
            Console.WriteLine($"Instituição: {InstituicaoFormacao}");
            Console.WriteLine($"Curso: {CursoFormacao}");
            Console.WriteLine($"Nível Académico: {NivelAcademicoFormacao}");
            Console.WriteLine($"Ano de Ingresso: {AnoIngressoFormacao}");
            Console.WriteLine($"Ano de Conclusão: {AnoConclusaoFormacao}");
            Console.WriteLine($"Média de Conclusão: {MediaConclusao}");

            Console.WriteLine("\n--- Candidatura ---");
            Console.WriteLine("         \n=== DADOS DA CANDIDATURA ===");
            Console.WriteLine($"Instituição: {InstituicaoCandidatura}");
            Console.WriteLine($"Curso: {CursoCandidatura}");
            Console.WriteLine($"Nível Académico: {NivelAcademicoCandidatura}");
            Console.WriteLine($"Ano de Ingresso: {AnoIngressoCandidatura}");
            Console.WriteLine($"Ano de Frequência: {AnoFrequenciaCandidatura}");
        }
    }

}
