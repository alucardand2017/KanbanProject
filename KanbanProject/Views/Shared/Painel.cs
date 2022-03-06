using System;
using System.Linq;
using KanbanProject.Models;
using KanbanProject.Models.Enums;
namespace KanbanProject.Views.Shared
{
    static class Painel
    {
        public static void ImprimirCabecalho(Cliente cliente)
        {
            Console.Clear();
            TextoBranco();
            ImprimirLinha();
            TextoVermelhoEscuro();
            Console.Write("|*************************************************| QUADRO KANBAN |****************************************************|");
            Console.WriteLine();
            TextoBranco();
            ImprimirLinha();
            Console.Write("|      Backlog  \t\t Especificação \t\t\t Implementação \t\t\t Revisão de Código\t|");
            Console.WriteLine();
            Console.Write($"|                                      {cliente.WIPEspec}                               {cliente.WIPImple}                          {cliente.WIPRev}   |                |");
            Console.WriteLine();
            TextoBranco();
            ImprimirLinha();

            ImprimirLinha();
        }

        public static void ImprimirCorpo(Projeto projeto)
        {
            var h1 = projeto.Historias.Where(p => p.Posicao == PosicaoKanban.Backlog).ToList();
            var h2 = projeto.Historias.Where(p => p.Posicao == PosicaoKanban.Espec_doing).ToList();
            var h3 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Espec_done).ToList();
            var h4 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Deploy_doing).ToList();
            var h5 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Deploy_done).ToList();
            var h6 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Revision_doing).ToList();
            var h7 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Revision_done).ToList();
            int[] aux1 = { 14, 19, 19, 13, 17, 14, 15 };
            int[] aux2 = { 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("|\t\t|\tem espec.   |    espeficicada\t| em Impleme. |  Implementada\t|\tem rev.| revisada\t|");
            for (int j = 0; j < 2; j++)
            {
                Console.Write("| ");
                TextoVerde();
                foreach (var item in h1)
                {
                    if ((aux1[0] - 3 * aux2[0]) > 3)
                    {
                        Console.Write(item.NomeHistoria + " ");
                        aux2[0]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[0] - 3 * aux2[0]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|"); //mudei


                TextoVerde();
                foreach (var item in h2)
                {
                    if ((aux1[1] - 3 * aux2[1]) > 3)
                    {
                        Console.Write(item.NomeHistoria + " ");
                        aux2[1]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[1] - 3 * aux2[1]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|"); //mudei




                TextoVerde();
                foreach (var item in h3)
                {
                    if ((aux1[2] - 3 * aux2[2]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[2]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[2] - 3 * aux2[2]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");






                TextoVerde();
                foreach (var item in h3)
                {
                    if ((aux1[3] - 3 * aux2[3]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[3]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[3] - 3 * aux2[3]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");






                TextoVerde();
                foreach (var item in h5)
                {
                    if ((aux1[4] - 3 * aux2[4]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[4]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[4] - 3 * aux2[4]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");






                TextoVerde();
                foreach (var item in h6)
                {
                    if ((aux1[5] - 3 * aux2[5]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[5]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[5] - 3 * aux2[5]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");






                TextoVerde();
                foreach (var item in h7)
                {
                    if ((aux1[6] - 3 * aux2[6]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[6]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TextoBranco();
                for (int i = 0; i < (aux1[6] - 3 * aux2[6]); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                ImprimirLinha();
            }
        }
        public static void ImprimirProjeto(Projeto projeto)
        {
            ImprimeInfo(projeto.NomeProjeto.ToUpper(), projeto.Descricao.ToUpper());
            TextoAmareloEscuro();
            Console.Write("Data:");
            TextoAmarelo();
            Console.Write(projeto.DataInicio);
            TextoAmareloEscuro();
            Console.Write("-Previsão: ");
            TextoAmarelo();
            Console.WriteLine(projeto.DataFim);
            TextoBranco();
            foreach (var item in projeto.Historias)
            {
                ImprimeInfo(item.NomeHistoria, item.Descricao);
            }
            foreach (var item in projeto.Tarefas)
            {
                ImprimeInfo(item.NomeTarefa, item.Descricao);
            }
        }
        public static void ImprimirTelaPrincipal(Cliente cliente, Projeto projeto)
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.Beep();
            Console.Title = "QUADRO KANBAN";
            ImprimirCabecalho(cliente);
            ImprimirCorpo(projeto);
            ImprimirProjeto(projeto);
            TextoBranco();
        }
        public static void ImprimeInfo(string nome, string descricao)
        {
            TextoBranco();
            ImprimirLinha();
            TextoAmareloEscuro();
            Console.Write(nome + "  => ");
            TextoAmarelo();
            Console.WriteLine(descricao);
        }
        //estruturas básicas do layout
        public static void ImprimirLinha()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public static void TextoAmarelo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void TextoBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextoAmareloEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public static void TextoVermelhoPerigo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void TextoVermelhoEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void TextoVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void TextoVerdeEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void TextoAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void TextoAzulEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}
