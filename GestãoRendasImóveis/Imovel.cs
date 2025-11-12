using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Imovel
    {
        #region Atributos

        int idImovel;
        string tipo;
        string morada;
        double area;
        string estado;
        string distrito;
        string concelho;
        string freguesia;

        #endregion

        #region Construtores

        public Imovel(int idImovel, string tipo, double area, string estado, string distrito, string concelho, string freguesia, string morada)
        {
            this.idImovel = idImovel;
            this.tipo = tipo;
            this.morada = morada;
            this.area = area;
            this.estado = estado;
            this.distrito = distrito;
            this.concelho = concelho;
            this.freguesia = freguesia;
        }

        #endregion

        #region Propriedades

        public int IdImovel
        {
            get { return idImovel; }
            set { idImovel = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }

        public string Concelho
        {
            get { return concelho; }
            set { concelho = value; }
        }

        public string Freguesia
        {
            get { return freguesia; }
            set { freguesia = value; }
        }

        #endregion

        #region Métodos

        public void MostrarInfoImovel()
        {
            Console.WriteLine("\n--- Detalhes Atuais do Imóvel ---");
            Console.WriteLine($"ID: {idImovel}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Área: {area} m2");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Localização: {distrito}, {concelho}, {freguesia}");
            Console.WriteLine($"Morada: {morada}");
            Console.WriteLine("-----------------------------------");
        }

        #endregion
    }
}
