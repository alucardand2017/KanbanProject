using System;
using KanbanProject.Models.Enums;

namespace KanbanProject.Models.Services
{
    class TarefaService
    {
        public static void CadastrarTarefa(Projeto projeto)
        {
            Console.Write("Nome da Tarefa: ");
            string nome = Console.ReadLine();
            string descricao = "Descricao Como montar uma lista de viagem. Montar uma lista do que levar para a viagem e das pendências que devem ser resolvidas antes de partir é o primeiro passo do seu planejamento";
            Console.WriteLine("Digite a descricao da tarefa: " + descricao);
            Console.WriteLine("Digite a posição da Tarefa: (1)(2)(3)(4)(5)(6)(7)");
            int posicao = int.Parse(Console.ReadLine());
            Console.Write("Qual o peso dessa Tarefa: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Tarefas.Add(new Tarefa(nome,descricao, PosicaoKanban.Backlog, peso));
        }
    }
}
