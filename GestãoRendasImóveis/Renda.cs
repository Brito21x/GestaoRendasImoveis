using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Renda
    {
        #region Atributos

        int idRenda;
        int idContrato;
        decimal valor;
        DateTime dataPagamento;
        bool paga;

        #endregion

        #region Construtores

        public Renda(int idRenda, int idContrato, decimal valor, DateTime dataPagamento, bool paga)
        {
            this.idRenda = idRenda;
            this.idContrato = idContrato;
            this.valor = valor;
            this.dataPagamento = dataPagamento;
            this.paga = paga;
        }

        public Renda()
        {
            this.idRenda = 0;
            this.idContrato = 0;
            this.valor = 0;
            this.dataPagamento = DateTime.Now.Date;
            this.paga = false;
        }

        #endregion

        #region Propriedades

        public int IdRenda
        {
            get { return idRenda; }
            set { idRenda = value; }
        }

        public int IdContrato
        {
            get { return idContrato; }
            set { idContrato = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value.Date; }
        }

        public bool Paga
        {
            get { return paga; }
            set { paga = value; }
        }

        #endregion

        #region Métodos

        public void MostrarInfoRenda()
        {
            Console.WriteLine($"\n--- Detalhes da Renda {IdRenda} ---");
            Console.WriteLine($"Contrato ID: {IdContrato}");
            Console.WriteLine($"Valor: {Valor} €");
            Console.WriteLine($"Data de Pagamento: {DataPagamento:d}");
            Console.WriteLine($"Estado: {(Paga ? "Paga" : "Pendente")}");
            Console.WriteLine("-----------------------------------");
        }
        #endregion
    }
}

