using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEC_SOFT
{
    public class Bolsa
    {
        public string NomeBolsa { get; set; }
        public double Valor { get; set; }

        public Bolsa(string nomeBolsa, double valor)
        {
            NomeBolsa = nomeBolsa;
            Valor = valor;
        }

        public void MostrarBolsa()
        {
            Console.WriteLine($"Bolsa: {NomeBolsa}, Valor: {Valor:C}");
        }
    }

}
