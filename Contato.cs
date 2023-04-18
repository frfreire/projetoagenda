using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public class Contato: IComparable<Contato>
    {

        private string nome;
        private string email;
        private string telefone;

        public Contato() 
        { }

        public Contato(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public string GetNome() 
        { 
            return nome; 
        }

        public string GetEmail() 
        { 
            return email; 
        }
        public string GetTelefone() 
        {
            return telefone;
        }

        public void SetNome(string nome) 
        { 
            this.nome = nome; 
        }

        public void SetEmail(string email) 
        { 
            this.email = email;
        }

        public void SetTelefone(string telefone)
        { 
            this.telefone = telefone;
        }

        public int CompareTo(Contato? c)
        {
            return nome.CompareTo(c.nome);
        }
    }
}
