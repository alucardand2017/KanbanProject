using KanbanProject.Models;
using KanbanProject.Models.Repositories;
using KanbanProject.Models.Services;
using KanbanProject.Views.Shared;
using System;

namespace KanbanProject.Controller
{
    class MenuController
    {
        public static void MenuPrincipal(string path, Cliente cliente, int index)
        {
            int prjt = index;
            char cont = '0';
            do
            {
                Console.WriteLine("Digite uma escolha:  \n(1) - cadastrar projeto \n(2) - carregar projeto do cliente \n(3) - remover projeto \n(4) - alterar projeto \n(5) - config. WIP \n(6) - salvar alterações \n(7) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '1':
                        Console.Clear();
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        ProjetoServices.CadastrarProjeto(cliente);
                        Console.Clear();
                        prjt = cliente.Projetos.Count - 1;
                        cliente.IndexProjetoAtual = prjt;
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        Salvar.Caminho(cliente, path);
                        break;
                    case '2':
                        Console.Clear();
                        prjt = ProjetoServices.PesquisarGeralProjeto(cliente);
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        cliente.IndexProjetoAtual = prjt;
                        Salvar.Caminho(cliente, path);
                        break;
                    case '3':
                        Console.Clear();
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        ProjetoServices.RemoverProjeto(cliente);
                        Salvar.Caminho(cliente, path);
                        break;
                    case '4':
                        Console.Clear();
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        ProjetoServices.AlterarProjeto(cliente.Projetos[prjt]);
                        Salvar.Caminho(cliente, path);
                        break;
                    case '5':
                        Console.Clear();
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        KanbanService.CalcKanbanWIP(cliente);
                        Salvar.Caminho(cliente, path);
                        break;
                    case '6':
                        Console.Clear();
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        Salvar.Caminho(cliente, path);
                        break;
                    case '7':
                        break;
                    default:
                        cont = '0';
                        Console.WriteLine("Digite uma oção válida!"); break;
                }
            }
            while (cont != '7');
        }
    }
}
