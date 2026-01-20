using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SGEC_SOFT
{

    public static class GravacaoDados
    {
        private static string caminhoArquivo = "estudantes.txt";

        public static void SalvarEstudante(EstudanteBolseiro estudante)
        {
            string linha = $"{estudante.NomeCompleto},{estudante.DataNascimento.ToShortDateString()},{estudante.Sexo},{estudante.BI},{estudante.TelefonePrincipal},{estudante.Nacionalidade},{estudante.Naturalidade},{estudante.Pai},{estudante.Mae},{estudante.Endereco},{estudante.InstituicaoFormacao},{estudante.CursoFormacao},{estudante.NivelAcademicoFormacao},{estudante.AnoIngressoFormacao},{estudante.AnoConclusaoFormacao},{estudante.MediaConclusao},{estudante.InstituicaoCandidatura},{estudante.CursoCandidatura},{estudante.NivelAcademicoCandidatura},{estudante.AnoIngressoCandidatura},{estudante.AnoFrequenciaCandidatura},{estudante.TipoBolsa}";
            File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
            Console.WriteLine("Dados do estudante salvos com sucesso!");
        }
    }

}
