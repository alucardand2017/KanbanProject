using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Models.Services
{
    class ProjetoServices
    {
        public static void CadastrarProjeto(Cliente cliente)
        {
            Console.WriteLine("Cadastrar novo Projeto");
            Console.Write("Inserir Nome do Projeto: ");
            string nomeProjeto = Console.ReadLine();
            Console.WriteLine("Inserir o Cliente: " + cliente.Nome);
            Console.WriteLine("Inserir Descrição do projeto:"  + "PROJETO TESTE AQUI VIRIA O DESCRITIVO");
            string descricao  = "PROJETO TESTE AQUI VIRIA O DESCRITIVO";
            DateTime dataInicio = DateTime.Now;
            DateTime dataFim = DateTime.Now;
            Console.WriteLine("Inserir dono do produto: " + "Ciclano");
            string donoProduto = "Ciclano";
            cliente.Projetos.Add(new Projeto(nomeProjeto, descricao, dataInicio, dataFim, donoProduto));
        }
    }
}
