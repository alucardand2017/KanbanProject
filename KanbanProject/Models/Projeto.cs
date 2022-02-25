using System.Collections.Generic;
using KanbanProject.Views.Shared;
using System;

namespace KanbanProject.Models
{
    public class Projeto
    {
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string DonoProduto { get; set; }
        public List<Historia> Historias { get; set; } = new List<Historia>();
        public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
        public Projeto()
        {
        }
        public Projeto(string nomeProjeto, string descricao, DateTime dataInicio, DateTime dataFim, string donoProduto)
        {
            NomeProjeto = nomeProjeto;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DonoProduto = donoProduto;
        }
        public void PrintProjeto()
        {
            ConsoleColor cor = Painel.TextoAmarelo();
            System.Console.WriteLine($"\nProjeto : " + NomeProjeto);
            System.Console.WriteLine($"Descrição : " + Descricao);
            System.Console.WriteLine($"Data inicio : " + DataInicio);
            System.Console.WriteLine($"Data Final : " + DataFim);
            System.Console.WriteLine($"Responsável : " + DonoProduto);
            Painel.RetornaCorAnterior(cor);
            foreach (var item1 in Historias)
            {
                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Historia : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoAmareloEscuro();
                Console.Write(item1.NomeHistoria + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Descricao : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoAmareloEscuro();
                System.Console.WriteLine(item1.Descricao + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Posicao : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoAmareloEscuro();
                System.Console.Write(item1.Posicao + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Peso : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoAmareloEscuro();
                System.Console.Write(item1.Peso + "\t");
                Painel.RetornaCorAnterior(cor);
            }
            foreach (var item1 in Tarefas)
            {
                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Tarefa : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoVerdeEscuro();
                Console.Write(item1.NomeTarefa + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Descricao : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoVerdeEscuro();
                System.Console.WriteLine(item1.Descricao + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Posicao : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoVerdeEscuro();
                System.Console.Write(item1.Posicao + "\t");
                Painel.RetornaCorAnterior(cor);

                cor = Painel.TextoVermelhoEscuro();
                System.Console.Write($"Peso : ");
                Painel.RetornaCorAnterior(cor);
                cor = Painel.TextoVerdeEscuro();
                System.Console.Write(item1.Peso + "\t");
                Painel.RetornaCorAnterior(cor);
            }
        }
    }
}
   
