using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Senhorio : Pessoa
    {
        #region Atributos

        string contaIBAN;

        #endregion

        #region Construtores

        public Senhorio(string nome, string nif, string email, string telefone, string contaIBAN) : base(nome, nif, email, telefone)
        {
            this.contaIBAN = contaIBAN;
        }



        #endregion

        #region Propriedades

        public string ContaIBAN
        {
            get { return contaIBAN;}
            set { contaIBAN = value;}
        }

        #endregion

        #region Métodos

        public void MostrarInfoSenhorio()
        {
            Console.WriteLine($"\n--- Informações do Senhorio ---");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"NIF: {this.Nif}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Telefone: {this.Telefone}");

            Console.WriteLine($"Conta IBAN: {this.ContaIBAN}");
            Console.WriteLine($"------------------------------");
        }

        public void EmitirRecibo()
        {
            Console.WriteLine("Recibo emitido.");
        }

        #endregion
    }
}
