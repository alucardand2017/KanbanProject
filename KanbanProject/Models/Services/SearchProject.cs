using System;
using System.Collections.Generic;
using System.Linq;

namespace KanbanProject.Models.Services
{
    class SearchProject
    {
       
        public static int Varrer(Cliente cliente)
        {
            int index = 0;
            foreach (var item in cliente.Projetos)
            {
                Console.Write("("+index+") - ");
                item.PrintProjeto();
                index++;
            }
            int cont = cliente.Projetos.Count;
            if(cont != 0)
            {
                Console.WriteLine("Digite o número do projeto que deseja puxar:");
                for (int i = 0; i < cont; i++)
                    Console.WriteLine($"- ({i})");
                return int.Parse(Console.ReadLine()) ;
            }
            throw new ArgumentException("não há projetos listados nessas condições!");
        }
    }
}
