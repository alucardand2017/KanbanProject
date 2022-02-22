using System.Collections.Generic;
using KanbanProject.Models.Enums;
using KanbanProject.Models;
using System.ComponentModel.DataAnnotations;
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

            System.Console.WriteLine($"Projeto  {count}: " + NomeProjeto);
            System.Console.WriteLine($"Descrição : " + Descricao);
            System.Console.WriteLine($"Data inicio : " + DataInicio);
            System.Console.WriteLine($"Data Final : " + DataFim);
            System.Console.WriteLine($"Responsável : " + DonoProduto);
            foreach (var item1 in Historias)
            {
                System.Console.WriteLine($"Historia : " + item1.NomeHistoria);
                System.Console.WriteLine($"Posicão : " + item1.Posicao);
                System.Console.WriteLine($"Peso : " + item1.Peso);
            }
            foreach (var item1 in Tarefas)
            {
                System.Console.WriteLine($"Tarefa : " + item1.NomeTarefa);
                System.Console.WriteLine($"Posicão : " + item1.Posicao);
                System.Console.WriteLine($"Peso : " + item1.Peso + "\n");
            }
            count++;
        }
    }
}
   