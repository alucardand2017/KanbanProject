using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KanbanProject.Models.Services
{
    class ProjetoServices
    {
        public static void CadastrarProjeto(Cliente cliente)
        {
            Console.WriteLine("Cadastrar novo Projeto");
            Console.Write("Inserir Nome do Projeto: ");
            string nomeProjeto = Console.ReadLine();
            Console.WriteLine("Inserir Descrição do projeto:" + "PROJETO TESTE AQUI VIRIA O DESCRITIVO");
            string descricao = "PROJETO TESTE AQUI VIRIA O DESCRITIVO";
            DateTime dataInicio = DateTime.Now;
            DateTime dataFim = DateTime.Now;
            Console.WriteLine("Inserir dono do produto: " + "Ciclano");
            string donoProduto = "Ciclano";
            cliente.Projetos.Add(new Projeto(nomeProjeto, descricao, dataInicio, dataFim, donoProduto));
        }
        public static void PesquisarProjeto(Cliente cliente)
        {
            bool mantenha = true;
            while(mantenha)
            {
                Console.WriteLine("Escolha um parâmetro de pesquisa: (1) nome (2) dono do produto (qualquer outra) voltar");
                string escolha = Console.ReadLine();
                var i = TestaEntrada.Inteiro(escolha);
                switch (i)
                {
                    case 1:
                        Console.Write("Digite o nome ou parte do nome do projeto: ");
                        string nome = Console.ReadLine();
                        var r1 = cliente.Projetos.Where(p => p.NomeProjeto.Contains(nome)).ToList();
                        foreach (Projeto item in r1)
                        {
                            item.PrintProjeto();
                        }
                        break;
                    case 2:
                        Console.Write("Digite o nome do dono do produto ou parte dele: ");
                        string dono = Console.ReadLine();
                        var r2 = cliente.Projetos.Where(p => p.DonoProduto.Contains(dono)).ToList();
                        foreach (var item in r2)
                        {
                            item.PrintProjeto();
                        }
                        break;
                    default:
                        mantenha = false;
                        break;
                }
            }
        }
    }
}

