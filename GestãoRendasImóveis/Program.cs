using System.Security.Cryptography.X509Certificates;

namespace GestãoRendasImóveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Senhorio senhorio1 = new Senhorio("João Mário", "255 213 221", "senhorio@gmai.com", "+351 962862554", "PT5000 203159213020");
            Inquilino inquilino1 = new Inquilino("Pedro Ferreira", "293142983", "email@inquilino.com", "+351 966226234", DateTime.Now.Date , true);
            Imovel imovel1 = new Imovel(1, "Apartamento",250, "Ocupado", "Braga", "Barcelos", "Vila Frescainha S. Pedro", "Rua Dr. Mário Nº240");
            Contrato contrato1 = new Contrato( 1,imovel1.IdImovel, inquilino1.Nome, DateTime.Now.Date, DateTime.Now.Date.AddYears(1), 750, "Ativo");
            Recibo recibo1 = new Recibo(1, contrato1.IdContrato , DateTime.Now.Date, 75);

            senhorio1.MostrarInfoSenhorio();
            inquilino1.MostrarInfoInquilino();
            imovel1.MostrarInfoImovel();
            recibo1.MostrarInfoRecibo();

        }
    }
}
