using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace GestãoRendasImóveis
    {
        internal class Contrato
        {
            #region Atributos

            int idContrato;
            int idImovel;
            string inquilino;
            decimal valorRendaMensal;
            string estadoContrato;
            Recibo[] recibos;
            int totalRecibos;
            const int MAX_RECIBOS = 120;

            DateTime dataInicio;
            DateTime dataFim;

            #endregion

            #region Construtores

            public Contrato(int idContrato, int idImovel, string inquilino, DateTime dataInicio, DateTime dataFim, decimal valorRendaMensal, string estadoContrato)
            {
                this.idContrato = idContrato;
                this.idImovel = idImovel;
                this.inquilino = inquilino;
                this.valorRendaMensal = valorRendaMensal;
                this.estadoContrato = estadoContrato;

                this.DataInicio = dataInicio;
                this.DataFim = dataFim;

                this.recibos = new Recibo[MAX_RECIBOS];
                this.totalRecibos = 0;
            }

            public Contrato()
            {
                this.inquilino = "";
                this.idContrato = 0;
                this.idImovel = 0;
                this.valorRendaMensal = 0;
                this.estadoContrato = "Pendente";

                this.DataInicio = DateTime.Now.Date;
                this.DataFim = DateTime.Now.Date.AddYears(1);

                this.recibos = new Recibo[MAX_RECIBOS];
                this.totalRecibos = 0;
            }

            #endregion

            #region Propriedades

            public int IdContrato
            {
                get { return idContrato; }
                set { idContrato = value; }
            }

            public int IdImovel
            {
                get { return idImovel; }
                set { idImovel = value; }
            }

            public int Inquilino
            {
                get { return Inquilino; }
                set { Inquilino = value; }
            }

            public decimal ValorRendaMensal
            {
                get { return valorRendaMensal; }
                set { valorRendaMensal = value; }
            }

            public string EstadoContrato
            {
                get { return estadoContrato; }
                set { estadoContrato = value; }
            }

        public Recibo[] Recibos
        {
            get
            {
                return recibos;
            }
            set
            {
                recibos = value;
            }
        }
        public int TotalRecibos
            {
                get { return totalRecibos; }
                set { totalRecibos = value; }
            }

            public DateTime DataInicio
            {
                get { return dataInicio; }
                set { dataInicio = value.Date; }
            }

            public DateTime DataFim
            {
                get { return dataFim; }
                set
                { DateTime dataFim = value.Date; }
            }

            #endregion

            #region Métodos

            public void MostrarInfoContrato()
            {
                Console.WriteLine($"\n--- Detalhes do Contrato {IdContrato} ---");
                Console.WriteLine($"Imóvel ID: {IdImovel} | Inquilino: {Inquilino}");
                Console.WriteLine($"Vigência: {DataInicio:d} a {DataFim:d}");
                Console.WriteLine($"Duração: {(DataFim - DataInicio).TotalDays / 30.4:F0} meses.");
                Console.WriteLine($"Renda Mensal: {ValorRendaMensal} € | Estado: {EstadoContrato}");
                Console.WriteLine($"Recibos emitidos: {TotalRecibos}");
                Console.WriteLine("-------------------------------------");
            }

            #endregion
        }
    }

