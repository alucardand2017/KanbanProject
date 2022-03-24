using KanbanProject.Models;
using KanbanProject.Models.Repositories;
using KanbanProject.Models.Services;
using KanbanProject.Views.Shared;
using System;
using System.IO;
using System.Threading;

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
                Console.WriteLine("Digite uma opção:  \n(1) - cadastrar projeto (2) - carregar projeto do cliente (3) - remover projeto " +
                    "\n(4) - alterar projeto   (5) - config. WIP                 (6) - salvar alterações (7) - sair");
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
    
        public static void VerificandoBancoDeDados(string fullPath)
        {
            string stringFile = "";

            using (StreamReader sr = new StreamReader(fullPath))
            {

                stringFile = sr.ReadToEnd();
                if (String.IsNullOrEmpty(stringFile))
                {
                    Cliente _cliente = new Cliente();
                    Console.WriteLine("Nome do cliente: ");
                    _cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Endereco do cliente: ");
                    _cliente.Endereco = Console.ReadLine();
                    Console.WriteLine("Telefone do cliente: ");
                    _cliente.Telefone = Console.ReadLine();
                    Tarefa tarefa = new Tarefa() { NomeTarefa = "T0", Descricao = "", Peso = 1, Posicao = Models.Enums.PosicaoKanban.Backlog };
                    Historia historia = new Historia() { NomeHistoria = "H0", Descricao = "", Peso = 1, Posicao = Models.Enums.PosicaoKanban.Backlog };
                    Projeto projeto1 = new Projeto() { NomeProjeto = "P0", Descricao = "" };
                    _cliente.Projetos.Add(projeto1);
                    _cliente.Projetos[0].Tarefas.Add(tarefa);
                    _cliente.Projetos[0].Historias.Add(historia);
                    _cliente.IndexProjetoAtual = 0;
                    sr.Close();
                    Salvar.Caminho(_cliente, fullPath);
                }
                sr.Close();
            }
        }
    }
}
