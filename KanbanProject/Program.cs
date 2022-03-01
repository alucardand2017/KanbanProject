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

            Console.SetBufferSize(1000, 1000);





           
            try
            {
                Cliente cliente = new Cliente();
                cliente = Carregar.CaminhoCarregar();
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
                        Console.WriteLine("PROJETO ATUAL: ");
                        cliente.Projetos[prjt -1].PrintProjeto();
                        Console.WriteLine();
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
                ConsoleColor cor = Painel.TextoVermelhoPerigo();
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message);
                Painel.RetornaCorAnterior(cor);
            }
        
        }
    }
}
