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
                Console.WriteLine("Digite uma escolha:  \n(1) - cadastrar projeto \n(2) - carregar projeto do cliente \n(3) - remover projeto \n(4) - alterar projeto \n(5) - config. WIP \n(6) - salvar alterações \n(7) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '1':
                        ProjetoServices.CadastrarProjeto(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case '2':
                        prjt = ProjetoServices.PesquisarGeralProjeto(cliente);
                        Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[prjt]);
                        cliente.IndexProjetoAtual = prjt;
                        Salvar.Caminho(cliente);
                        break;
                    case '3':
                        ProjetoServices.RemoverProjeto(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case '4':
                        ProjetoServices.AlterarProjeto(cliente.Projetos[prjt]);
                        Salvar.Caminho(cliente);
                        break;
                    case '5':
                        KanbanService.CalcKanbanWIP(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case '6':
                        Salvar.Caminho(cliente);
                        Console.WriteLine("Dados salvos com sucesso!");
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
