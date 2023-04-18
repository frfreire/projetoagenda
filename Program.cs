namespace ProjetoAgenda
{


    public class Program
    {

        public static void Main(string[] args)
        {
            Agenda agenda = new();



            while (true) { 

                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Listar contatos");
                Console.WriteLine("3 - Editar contato");
                Console.WriteLine("4 - Excluir contato");
                Console.WriteLine("5 - Sair");
                Console.WriteLine();

                string op = Console.ReadLine();
                Console.WriteLine();

                switch (op) {

                    case "1":
                        agenda.AdicionarContato();
                        break;
                    case "2":
                        agenda.ListarContatos();
                        break;
                    case "3":
                        agenda.EditarContato();
                        break;
                    case "4":
                        agenda.RemoverContato();
                        break;
                    case "5":
                        return;
                }

            }
            

        }
    
    }

}