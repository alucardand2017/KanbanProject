using KanbanProject.Models;
using KanbanProject.Models.Repositories;
using KanbanProject.Models.Services;
using KanbanProject.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Controller
{
    class MenuController
    {
        public static void MenuPrincipal(Cliente cliente, int index)

        {
            int prjt = index;
            char cont = '0';
            do
            {
                Console.WriteLine("Digite uma escolha:  \n(1) - cadastrar projeto \n(2) - carregar projeto do cliente \n(3) - remover projeto \n(4) - alterar projeto \n(5) - salvar alterações \n(6) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '1':
                        ProjetoServices.CadastrarProjeto(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case '2':
                        prjt = ProjetoServices.PesquisarGeralProjeto(cliente);
                        Painel.ImprimirTelaPrincipal(cliente.Projetos[prjt]);
                        cliente.IndexProjetoAtual = prjt;
                        Salvar.Caminho(cliente);
                        break;
                    case '3':
                        ProjetoServices.RemoverProjeto(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case '4':
                        AlterarProjeto(cliente.Projetos[prjt]);
                        Salvar.Caminho(cliente);
                        break;
                    case '5':
                        Salvar.Caminho(cliente);
                        Console.WriteLine("Dados salvos com sucesso!");
                        break;
                    case '6':
                        break;
                    default:
                        cont = '0';
                        Console.WriteLine("Digite uma oção válida!"); break;
                }
            }
            while (cont != '6');
        }
        public static void AlterarProjeto(Projeto projeto)
        {
            char cont = '0';
            do
            {
                Console.WriteLine("Escolha uma opção:  \n(1) - cadastrar Historia \n(2) - alterar Historia \n(3) - remover Historia \n(4)" +
                " cadastrar Tarefa \n(5) - alterar Tarefa \n(6) - remover Tarefa \n(7) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '1':
                        HistoriaService.CadastrarHistoria(projeto);
                        break;
                    case '2':
                        int index = HistoriaService.PesquisarHistorias(projeto);
                        HistoriaService.CadastrarHistoria(projeto, index);
                        Console.WriteLine("Alteração realizada com sucesso!");
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
