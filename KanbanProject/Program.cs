using System;
using System.Collections.Generic;
using KanbanProject.Models;
using KanbanProject.Models.Enums;
using KanbanProject.Models.Services;
using KanbanProject.Views;
using KanbanProject.Models.Repositories;
using KanbanProject.Views.Shared;

namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                Cliente cliente = new Cliente();
                Projeto projeto = new Projeto();
                //List<Funcionario> funcionarios = new List<Funcionario>();
                //ClienteService.CadastrarCliente(clientes);
                //ProjetoServices.CadastrarProjeto(clientes[0]);
                //HistoriaService.CadastrarHistoria(clientes[0].Projetos[0]);
                //TarefaService.CadastrarTarefa(clientes[0].Projetos[0]);
                //Salvar.Caminho(clientes[0]);
                cliente = Carregar.CaminhoCarregar();
                //Console.WriteLine(cliente);
                //cliente.PrintProjetos();

                char cont = 'n';
                while (cont != 's')
                {
                    Console.WriteLine("Digite uma escolha:  \n(c) - cadastrar projeto \n(p) - pesquisar projeto \n(r) - remover projeto \n(a) - alterar projeto \n(s) - sair" );
                    char.TryParse(Console.ReadLine().ToLower(), out cont);
                    
                    switch (cont)
                    {
                        case 'c':
                            ProjetoServices.CadastrarProjeto(cliente);
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
            }
            catch (Exception e)
            {
                ConsoleColor cor = Painel.TextoErro();
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message);
                Painel.RetornaCorAnterior(cor);
            }




        }
    }
}
