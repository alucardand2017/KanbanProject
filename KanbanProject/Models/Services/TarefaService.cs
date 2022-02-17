using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanbanProject.Models.Enums;

namespace KanbanProject.Models.Services
{
    class TarefaService
    {
        public static void CadastrarTarefa(Projeto projeto)
        {
            Console.Write("Nome da Tarefa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a posição da Tarefa: (1)(2)(3)(4)(5)(6)(7)");
            int posicao = int.Parse(Console.ReadLine());
            Console.Write("Qual o peso dessa Tarefa: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Tarefas.Add(new Tarefa(nome, PosicaoKanban.Backlog, peso));
        }
    }
}
