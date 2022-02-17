using System;
using System.Collections.Generic;
using KanbanProject.Models;
using KanbanProject.Models.Enums;
using KanbanProject.Models.Services;
using KanbanProject.Views;
using KanbanProject.Models.Repositories;
namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                List<Funcionario> funcionarios = new List<Funcionario>();
                ClienteService.CadastrarCliente(clientes);
                ProjetoServices.CadastrarProjeto(clientes[0]);
                HistoriaService.CadastrarHistoria(clientes[0].Projetos[0]);
                TarefaService.CadastrarTarefa(clientes[0].Projetos[0]);
                Salvar.Caminho(clientes[0]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            



        }
    }
}
