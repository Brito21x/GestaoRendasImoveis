using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Inquilino : Pessoa
    {
        #region Atributos

        DateTime dataEntrada;
        bool ativo;

        #endregion

        #region Construtores

        public Inquilino(string nome, string nif, string email, string telefone, DateTime dataEntrada, bool ativo)
            : base(nome, nif, email, telefone)
        {
            this.dataEntrada = dataEntrada;
            this.ativo = ativo;
        }

        #endregion

        #region Propriedades

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        #endregion

        #region Métodos

        public void MostrarInfoInquilino()
        {
            Console.WriteLine($"\n--- Informações do Inquilino ---");

            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"NIF: {this.Nif}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Telefone: {this.Telefone}");

            Console.WriteLine($"Data de Entrada: {this.DataEntrada}");
            Console.WriteLine($"Estado (Ativo): {(this.Ativo ? "Sim":"Não")}");
            Console.WriteLine($"---------------------------------");
        }

        public void PagarRenda()
        {
            Console.WriteLine("Renda paga.");
        }
        #endregion
    }
}
