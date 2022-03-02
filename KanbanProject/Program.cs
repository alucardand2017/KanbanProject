using System;
using KanbanProject.Models;
using KanbanProject.Views.Shared;
using KanbanProject.Models.Repositories;
using KanbanProject.Models.Services;

namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.Beep();
            Cliente cliente = new Cliente();
            cliente = Carregar.CaminhoCarregar();
            Painel.ImprimirCabecalho(cliente.Projetos[2]);
            Painel.ImprimirCorpo(cliente.Projetos[2]);
            Painel.ImprimirProjeto(cliente.Projetos[2]);
            Painel.TextoBranco();

            try
            {
                //List<Funcionario> funcionarios = new List<Funcionario>();
                //ClienteService.CadastrarCliente(clientes);
                //ProjetoServices.CadastrarProjeto(clientes[0]);
                //HistoriaService.CadastrarHistoria(clientes[0].Projetos[0]);
                //TarefaService.CadastrarTarefa(clientes[0].Projetos[0]);
                //Salvar.Caminho(clientes[0]);
                //Console.WriteLine(cliente);
                //cliente.PrintProjetos();
                
                char cont;
                Console.WriteLine("Digite uma escolha:  \n(c) - cadastrar projeto \n(p) - pesquisar projeto \n(r) - remover projeto \n(a) - alterar projeto \n(s) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);

                switch (cont)
                {
                    case 'c':
                        ProjetoServices.CadastrarProjeto(cliente);
                        Salvar.Caminho(cliente);
                        break;
                    case 'p':
                        int prjt = ProjetoServices.PesquisarGeralProjeto(cliente);
                        break;
                    case 'r':
                        ProjetoServices.RemoverProjeto(cliente);
                        break;
                    case 'a':
                        ProjetoServices.AlterarProjeto(cliente);
                        break;
                    case 's':
                        break;
                    default:
                        cont = 's';
                        break;
                }
            }
            catch (Exception e)
            {
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message);
            }
            
            
        }
    }
}

