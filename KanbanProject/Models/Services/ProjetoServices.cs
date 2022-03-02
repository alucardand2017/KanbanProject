using System;
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
            int resp = SearchProject.Search(cliente);
            Console.Clear();
            return resp;
        }
        public static void RemoverProjeto(Cliente cliente)
        {
            Painel.TextoAmarelo();
            int resp = PesquisarGeralProjeto(cliente);
            Console.WriteLine("Deseja realmente deletar esse projeto?");
            char.TryParse(Console.ReadLine(), out char del);
            if (del == 's')
            {
                cliente.Projetos.Remove(cliente.Projetos[resp - 1]);
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Projeto Removido com sucesso!");
            }


        }
        public static void AlterarProjeto(Cliente cliente)
        {
            throw new NotImplementedException("ainda não implementado!");
        }
    }
}

