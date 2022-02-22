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
            int count = 1;
            ConsoleColor cor = Painel.TextoDigitacao();
            System.Console.WriteLine($"Projeto  {count}: " + NomeProjeto);
            System.Console.WriteLine($"Descrição : " + Descricao);
            System.Console.WriteLine($"Data inicio : " + DataInicio);
            System.Console.WriteLine($"Data Final : " + DataFim);
            System.Console.WriteLine($"Responsável : " + DonoProduto + "\n");
            Painel.RetornaCorAnterior(cor);
            cor = Painel.TextoDestaque();
            foreach (var item1 in Historias)
            {
                System.Console.Write($"Historia : " + item1.NomeHistoria +"\t");
                System.Console.Write($"Posicão : " + item1.Posicao + "\t");
                System.Console.Write($"Peso : " + item1.Peso + "\n");
            }
            Painel.RetornaCorAnterior(cor);
            cor = Painel.TextoErro();
            foreach (var item1 in Tarefas)
            {
                System.Console.Write($"Tarefa : " + item1.NomeTarefa + "\t");
                System.Console.Write($"Posicão : " + item1.Posicao + "\t");
                System.Console.Write($"Peso : " + item1.Peso + "\n");
            }
            Painel.RetornaCorAnterior(cor);
            count++;
        }
    }
}
   