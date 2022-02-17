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
        public override string ToString()
        {
            return
                "\nNome: " +
                NomeProjeto +                
                "Descricao:" +
                Descricao +
                "\n" +
                "Data Inicio: " +
                DataInicio +
                 "Data final: " +
                DataFim +
                "\n";    
        }
    }

}