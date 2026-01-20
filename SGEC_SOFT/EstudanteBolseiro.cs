using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEC_SOFT
{

    public class EstudanteBolseiro : Estudante
    {
        public string TipoBolsa { get; set; }

        public EstudanteBolseiro(string nomeCompleto, DateTime dataNascimento, string sexo, string bi, string telefonePrincipal, string nacionalidade, string naturalidade, string pai, string mae, string endereco,
                                 string instituicaoFormacao, string cursoFormacao, string nivelAcademicoFormacao, int anoIngressoFormacao, int anoConclusaoFormacao, double mediaConclusao,
                                 string instituicaoCandidatura, string cursoCandidatura, string nivelAcademicoCandidatura, int anoIngressoCandidatura, int anoFrequenciaCandidatura,
                                 string tipoBolsa)
            : base(nomeCompleto, dataNascimento, sexo, bi, telefonePrincipal, nacionalidade, naturalidade, pai, mae, endereco,
                   instituicaoFormacao, cursoFormacao, nivelAcademicoFormacao, anoIngressoFormacao, anoConclusaoFormacao, mediaConclusao,
                   instituicaoCandidatura, cursoCandidatura, nivelAcademicoCandidatura, anoIngressoCandidatura, anoFrequenciaCandidatura)
        {
            TipoBolsa = tipoBolsa;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo de Bolsa: {TipoBolsa}");
        }
    }

}
