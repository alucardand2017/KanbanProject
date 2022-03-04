using System;
using KanbanProject.Models.Repositories;
using KanbanProject.Views.Shared;
using System.Globalization;
namespace KanbanProject.Models.Services
{
    class ProjetoServices
    {
        public static void CadastrarProjeto(Cliente cliente)
        {
            Console.Write("Inserir Nome do Projeto: ");
            string nomeProjeto = Console.ReadLine();
            Console.WriteLine("Inserir Descrição do projeto:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Data de Inicio: (dd/MM/YYYY)");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Previsão de término: (dd/MM/YYYY)");
            DateTime dataFim = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write ("Inserir responsável do produto: ");
            string donoProduto = Console.ReadLine();
            cliente.Projetos.Add(new Projeto(nomeProjeto, descricao, dataInicio, dataFim, donoProduto));
        }
        public static void CadastrarProjeto(Projeto projeto)
        {
            Painel.TextoBranco();
            Console.Write("Inserir Nome do Projeto: ");
            projeto.NomeProjeto = Console.ReadLine();
            Console.WriteLine("Inserir Descrição do projeto:");
            projeto.Descricao = Console.ReadLine();
            Console.WriteLine("Data de Inicio: (dd/MM/YYYY)");
            projeto.DataInicio = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Previsão de término: (dd/MM/YYYY)");
            projeto.DataFim = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Inserir responsável do produto: ");
            projeto.DonoProduto = Console.ReadLine();
        }
        public static int PesquisarGeralProjeto(Cliente cliente)
        {
            int index = 0;
            foreach (var item in cliente.Projetos)
            {
                Console.Write("(" + index + ") - ");
                item.PrintProjeto();
                index++;
            }
            int cont = cliente.Projetos.Count;
            if (cont != 0)
            {
                Console.WriteLine("Digite o número do projeto que deseja puxar:");
                for (int i = 0; i < cont; i++)
                    Console.WriteLine($"- ({i})");
                return int.Parse(Console.ReadLine());
            }
            throw new ArgumentException("não há projetos listados nessas condições!");
        }
        public static void RemoverProjeto(Cliente cliente)
        {
            Painel.TextoAmarelo();
            int resp = PesquisarGeralProjeto(cliente);
            Painel.ImprimirProjeto(cliente.Projetos[resp]);
            Console.WriteLine("Deseja realmente deletar esse projeto? (s/n)");
            char.TryParse(Console.ReadLine(), out char del);
            if (del == 's')
            {
                cliente.Projetos.Remove(cliente.Projetos[resp]);
                cliente.IndexProjetoAtual = 0;
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Projeto Removido com sucesso!\n");
                Painel.TextoBranco();
            }
            else if (del == 'n')
                return;
            else
            {
                Console.WriteLine("digite um valor válido!");
                return;
            }

        }
        public static void AlterarProjeto(Projeto projeto)
        {
            char cont = '0';
            do
            {
                Console.WriteLine("Escolha uma opção:  \n(0) - alterar Informações Gerais \n(1) - cadastrar Historia \n(2) - alterar Historia \n(3) - remover Historia \n(4)" +
                " cadastrar Tarefa \n(5) - alterar Tarefa \n(6) - remover Tarefa \n(7) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '0':
                        Console.Clear();
                        Painel.ImprimeInfo(projeto.NomeProjeto, projeto.Descricao);
                        CadastrarProjeto(projeto);
                        break;
                    case '1':
                        HistoriaService.CadastrarHistoria(projeto);
                        break;
                    case '2':
                        HistoriaService.AlterarHistoria(projeto);
                        break;
                    case '3':
                        HistoriaService.RemoverHistoria(projeto);
                        break;
                    case '4':
                        TarefaService.CadastrarTarefa(projeto);
                        break;
                    case '5':
                        TarefaService.AlterarTarefa(projeto);
                        break;
                    case '6':
                        TarefaService.RemoverTarefa(projeto);
                        break;
                    case '7':
                        break;
                    default:
                        cont = '0';
                        Console.WriteLine("Digite uma oção válida!");
                        break;
                }
            } while (cont != '7');
        }
    }
}

