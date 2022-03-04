using System;
using KanbanProject.Models.Enums;
using KanbanProject.Views.Shared;

namespace KanbanProject.Models.Services
{
    class TarefaService
    {
        public static void CadastrarTarefa(Projeto projeto)
        {
            ListaTarefas(projeto);
            Console.WriteLine($"Nome da Tarefa:");
            string nome = Console.ReadLine();
            Console.WriteLine("Descreva rapidamente a Tarefa:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a posição da Tarefa: " +
                "(1) - Backlog\n" +
                "(2) - Especificando\n " +
                "(3) - Especificado\n " +
                "(4) - Implementando\n " +
                "(5) - Implementado\n " +
                "(6) - Revisando\n " +
                "(7) - Revisado\n");
            string posicao = Console.ReadLine();
            Console.Write("Qual o peso dessa Tarefa: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Tarefas.Add(new Tarefa(nome, descricao, Enum.Parse<PosicaoKanban>(posicao), peso));
        }
        public static void CadastrarTarefa(Projeto projeto, int index2)
        {
            Console.WriteLine($"Nome da Tarefa:");
            string nome = Console.ReadLine();
            Console.WriteLine("Descreva rapidamente a Tarefa:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a posição da Tarefa: " +
               "(1) - Backlog\n" +
                "(2) - Especificando\n " +
                "(3) - Especificado\n " +
                "(4) - Implementando\n " +
                "(5) - Implementado\n " +
                "(6) - Revisando\n " +
                "(7) - Revisado\n");
            string posicao = Console.ReadLine();
            Console.Write("Qual o peso dessa Tarefa: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Tarefas[index2].NomeTarefa = nome;
            projeto.Tarefas[index2].Descricao = descricao;
            projeto.Tarefas[index2].Posicao = Enum.Parse<PosicaoKanban>(posicao);
            projeto.Tarefas[index2].Peso = peso;
        }
        private static void ListaTarefas(Projeto projeto)
        {
            Console.Write($"Tarefas atuais: ");
            foreach (var item in projeto.Tarefas)
            {
                Console.Write("-" + item.NomeTarefa);
            }
            Console.WriteLine();
        }
        internal static void AlterarTarefa(Projeto projeto)
        {
            int index2 = PesquisarTarefas(projeto);
            CadastrarTarefa(projeto, index2);
            Console.WriteLine("Alteração realizada com sucesso!");
        }
        internal static void RemoverTarefa(Projeto projeto)
        {
            var h = PesquisarTarefas(projeto);
            Console.WriteLine(projeto.Tarefas[h].NomeTarefa + " => " + projeto.Tarefas[h].NomeTarefa);
            Console.WriteLine("Deseja realmente excluir essa história");
            char.TryParse(Console.ReadLine(), out char escolha);
            if (escolha == 's')
            {
                projeto.Tarefas.Remove(projeto.Tarefas[h]);
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Historia Removida com sucesso!\n");
                Painel.TextoBranco();
            }
            else if (escolha == 'n')
                return;
            else
            {
                Console.WriteLine("digite um valor válido!");
                return;
            }
        }
        public static int PesquisarTarefas(Projeto projeto)
        {
            ListaTarefas(projeto);
            Console.WriteLine("Qual o nome da Tarefa?");
            string nome = Console.ReadLine().Trim().ToUpper();
            int i = projeto.Tarefas.FindIndex(p => p.NomeTarefa == nome);
            if (i < 0 || i > projeto.Historias.Count)
            {
                Console.WriteLine("Tarefa não encontrada, retornando melhor resultado.");
                return 0;
            }
            else
                return i;
        }

       
    }
}
