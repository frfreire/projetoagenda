using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public class Agenda : IAgenda
    {
        private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato()
        {
            Console.WriteLine("Adicionando um novo contato");
            Console.WriteLine("      ");

            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite um telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite um email: ");
            string email = Console.ReadLine();

            Contato c = new Contato(nome, email, telefone); 
            contatos.Add(c);
            Console.WriteLine("Contato adicionado com sucesso!!");
        }

        public void EditarContato()
        {
            Console.WriteLine("Buscar contato pelo nome: ");
            string nome = Console.ReadLine();

            Contato contatoRegistrado = contatos.Find(c => c.GetNome().Equals(nome));

            if (contatoRegistrado == null)
            {
                Console.WriteLine("Contato não encontrado.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Digite o novo nome do contato");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo email do contato");
            string novoEmail = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone do contato");
            string novoTelefone = Console.ReadLine();

            contatoRegistrado.SetNome(novoNome);
            contatoRegistrado.SetEmail(novoEmail);
            contatoRegistrado.SetTelefone(novoTelefone);

            Console.WriteLine("Contato editado com sucesso.");
            Console.WriteLine();
        }

        public void ListarContatos()
        {
            if (contatos.Count > 0)
            {

                Console.WriteLine("Lista de contatos");

                foreach (Contato contato in contatos)
                {

                    Console.WriteLine("Nome:     " + contato.GetNome());
                    Console.WriteLine("Telefone: " + contato.GetTelefone());
                    Console.WriteLine("Email:    " + contato.GetEmail());
                    Console.WriteLine();
                }
            }
            else {

                Console.WriteLine("Sua agenda está vazia");
                Console.WriteLine();
                return;
                
            }

        }

        public void RemoverContato()
        {
            Console.WriteLine("Digite o nome do contato que você deseja excluir");
            string nome = Console.ReadLine();

            Contato contato = contatos.Find(c => c.GetNome().Equals(nome));

            if (contato != null)
            {

                contatos.Remove(contato);
                Console.WriteLine("Contato excluído com sucesso!");
                Console.WriteLine();

            }
            else {

                Console.WriteLine("Contato não localizado");
                Console.WriteLine();
                return;
            }
            
        }
    }
}
