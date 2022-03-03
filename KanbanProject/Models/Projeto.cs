﻿using KanbanProject.Views.Shared;
using System;
using System.Collections.Generic;
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
            Painel.TextoAmareloEscuro();
            System.Console.WriteLine($"Projeto : " + NomeProjeto);
            System.Console.WriteLine($"Descrição : " + Descricao);
            System.Console.WriteLine($"Data inicio : " + DataInicio);
            System.Console.WriteLine($"Data Final : " + DataFim);
            System.Console.WriteLine($"Responsável : " + DonoProduto);
            Painel.TextoBranco();
            Painel.ImprimirLinha();

            /*
            foreach (var item1 in Historias)
            {
                System.Console.Write($"Historia : ");
             Painel.TextoAmareloEscuro();
                Console.WriteLine(item1.NomeHistoria);
                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Descricao : ");
                Painel.TextoAmareloEscuro();
                System.Console.WriteLine(item1.Descricao);

                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Posicao : ");
                Painel.TextoAmareloEscuro();
                System.Console.Write(item1.Posicao + "\t");
                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Peso : ");
                Painel.TextoAmareloEscuro();
                System.Console.WriteLine(item1.Peso);
            }
            foreach (var item1 in Tarefas)
            {
                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Tarefa : ");
                Painel.TextoVerdeEscuro();
                Console.Write(item1.NomeTarefa + "\t");

                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Descricao : ");
                Painel.TextoVerdeEscuro();
                System.Console.WriteLine(item1.Descricao + "\t");

                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Posicao : ");
                Painel.TextoVerdeEscuro();
                System.Console.Write(item1.Posicao + "\t");

                Painel.TextoVermelhoEscuro();
                System.Console.Write($"Peso : ");
                Painel.TextoVerdeEscuro();
                System.Console.WriteLine(item1.Peso + "\t");
            }
            */
            Painel.ImprimirLinha();
        
        }
    
    }
}
   
