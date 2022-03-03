using System;
using KanbanProject.Models.Repositories;
using KanbanProject.Views.Shared;

namespace KanbanProject.Models.Services
{
    class ProjetoServices
    {
        public static void CadastrarProjeto(Cliente cliente)
        {
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
        public static int PesquisarGeralProjeto(Cliente cliente)
        {
            int resp = SearchProject.Varrer(cliente);
            Console.Clear();
            return resp;
        }
        public static void RemoverProjeto(Cliente cliente)
        {
            Painel.TextoAmarelo();
            int resp = PesquisarGeralProjeto(cliente);
            Painel.ImprimirProjeto(cliente.Projetos[resp]);
            Console.WriteLine("Deseja realmente deletar esse projeto? (s/n)");
            char.TryParse(Console.ReadLine(), out char del);
            if (del == 's')
            {
                cliente.Projetos.Remove(cliente.Projetos[resp]);
                cliente.IndexProjetoAtual = 0;
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Projeto Removido com sucesso!\n");
                Painel.TextoBranco();
            }
            else if (del == 'n')
                return;
            else
            {
                Console.WriteLine("digite um valor válido!");
                return;
            }

        }
       
    }
}

