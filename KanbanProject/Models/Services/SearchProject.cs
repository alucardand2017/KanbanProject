using System;
using System.Collections.Generic;
using System.Linq;

namespace KanbanProject.Models.Services
{
    class SearchProject
    {
        public static int Search(Cliente cliente)
        {
            Console.WriteLine("Digite o nome do projeto:");
            string nome = Console.ReadLine();
            return Varrer(cliente.Projetos, nome);
        }
        private static int Varrer(List<Projeto> r1, string parametro)
        {
            var r2 = r1.Where(p => p.NomeProjeto.Contains(parametro)).ToList();
            foreach (var item in r2)
            {
                item.PrintProjeto();
            }
            int cont = r2.Count;
            if(cont != 0)
            {
                Console.WriteLine("Digite o número do projeto que deseja puxar:");
                for (int i = 1; i <= cont; i++)
                {
                    Console.WriteLine($"- ({i})");
                }
                return int.Parse(Console.ReadLine());
            }
            throw new ArgumentException("não há projetos listados nesse cliente!");
        }
    }
}
