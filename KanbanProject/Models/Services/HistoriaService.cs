using System;
using KanbanProject.Models.Enums;

namespace KanbanProject.Models.Services
{
    class HistoriaService
    {
        public static void CadastrarHistoria(Projeto projeto)
        {
            Console.Write("Nome da Historia: ");
            string nome = Console.ReadLine();
            string descricao = "Descricao Como montar uma lista de viagem. Montar uma lista do que levar para a viagem e das pendências que devem ser resolvidas antes de partir é o primeiro passo do seu planejamento";
            Console.WriteLine("Descreva rapidamente a historia:" + descricao );
            Console.WriteLine("Digite a posição da historia: (1)(2)(3)(4)(5)(6)(7)");
            int posicao = int.Parse(Console.ReadLine());
            Console.Write("Qual o peso dessa historia: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Historias.Add(new Historia(nome, descricao ,PosicaoKanban.Backlog, peso));
        }
    }
}
