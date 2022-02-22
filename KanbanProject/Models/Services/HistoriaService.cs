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
            Console.WriteLine("Digite a posição da historia: (1)(2)(3)(4)(5)(6)(7)");
            int posicao = int.Parse(Console.ReadLine());
            Console.Write("Qual o peso dessa historia: ");
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Historias.Add(new Historia(nome, PosicaoKanban.Backlog, peso));
        }
    }
}
