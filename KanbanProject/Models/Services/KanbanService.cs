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
            Console.Clear();
            Console.WriteLine("Primeiro, temos que estimar quanto tempo em média uma tarefa vai ficar em cada passo do Quadro Kanban.");
            Console.WriteLine("Digite o Lead Time (LT) de cada posição requeria abaixo.");
            Console.Write("Digite o LT do campo Especificação: ");
            double LTEspec = float.Parse(Console.ReadLine());

            Console.Write("Digite o LT do campo Implementação: ");
            double LTImple = float.Parse(Console.ReadLine());

            Console.Write("Digite o LT do campo Revisão: ");
            double LTRevis = float.Parse(Console.ReadLine());
            Console.WriteLine("Em seguida, deve-se estimar o throughput (TP) do passo com maior lead time do Quadro Kanban.");
            Console.Write("Digite a Capacidade de entrega (T/mes) do Time cujo LT informado acima seja o maior: ");
            double CT = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dias úteis de trabalho nesse mês: ");
            double DU = double.Parse(Console.ReadLine());
            double TP = CT / DU;
            cliente.WIPEspec = Math.Ceiling(TP * LTEspec * 1.50);
            cliente.WIPImple = Math.Ceiling(TP * LTImple * 1.50);
            cliente.WIPRev = Math.Ceiling(TP * LTRevis * 1.50);
            Console.WriteLine($" WIP Espec. = {cliente.WIPEspec} / WIP Impl = {cliente.WIPImple}/ WIP Rev = {cliente.WIPRev}");
        

        }
    }
}
