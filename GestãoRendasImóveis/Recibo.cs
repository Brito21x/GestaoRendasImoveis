using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Recibo
    {
        #region Atributos

        int idRecibo;
        int idContrato;
        DateTime dataEmissao;
        decimal valorPago;

        #endregion

        #region Construtores

        public Recibo(int idRecibo, int idContrato, DateTime dataEmissao, decimal valorPago)
        {
            this.idRecibo = idRecibo;
            this.idContrato = idContrato;
            this.dataEmissao = dataEmissao;
            this.valorPago = valorPago;
        }

        #endregion

        #region Propriedades

        public int IdRecibo
        {
            get { return idRecibo; }
            set { idRecibo = value; }
        }

        public int IdContrato
        {
            get { return idContrato; }
            set { idContrato = value; }
        }

        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        public decimal ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }

        #endregion

        #region Métodos

        public void MostrarInfoRecibo()
        {
            Console.WriteLine($"\n--- Detalhes do Recibo {idRecibo} ---");
            Console.WriteLine($"Contrato ID Associado: {idContrato}");
            Console.WriteLine($"Data de Emissão: {dataEmissao:d}");
            Console.WriteLine($"Valor Pago: {valorPago} €");
            Console.WriteLine("-----------------------------------");
        }

        #endregion
    }
}
