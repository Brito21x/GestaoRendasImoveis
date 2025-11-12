using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRendasImóveis
{
    internal class Pessoa
    {
        #region Atributos

        string nome;
        string nif;
        string email;
        string telefone;

        #endregion

        #region Construtores

        public Pessoa(string nome, string nif, string email, string telefone)
        {
            this.nome = nome;
            this.nif = nif;
            this.email = email;
            this.telefone = telefone;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome;  }
            set { nome = value; }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        #endregion
    }
}
