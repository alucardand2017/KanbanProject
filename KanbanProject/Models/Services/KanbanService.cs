using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Models.Services
{
    static class KanbanService
    {
        public static void CalcKanbanWIP( Cliente cliente)
        {
            Console.Write("Digite o LT da Especificação do Quadro: ");
            double LTEspec = float.Parse(Console.ReadLine());

            Console.Write("Digite o LT da Implementação do Quadro: ");
            double LTImple = float.Parse(Console.ReadLine());

            Console.Write("Digite o LT da Revisão do Quadro: ");
            double LTRevis = float.Parse(Console.ReadLine());

            Console.Write("Digite a Capacidade de entrega (T/mes) do Time de maior LT: ");
            double CT = double.Parse(Console.ReadLine());
            double TP = CT / 21;
            cliente.WIPEspec = Math.Ceiling(TP * LTEspec * 1.50);
            cliente.WIPImple = Math.Ceiling(TP * LTImple * 1.50);
            cliente.WIPRev = Math.Ceiling(TP * LTRevis * 1.50);
        }
    }
}
