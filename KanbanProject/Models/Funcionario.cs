using KanbanProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Models
{
    class Funcionario
    {
        public int Id { get; set; }
        public string NomeFuncionario { get; set; }
        public string Cargo { get; set; }
        public Nivel Nivel { get; set; }
        public decimal Salario { get; set; }
        public Funcionario()
        {
        }
        public Funcionario(int id, string nomeFuncionario, string cargo, Nivel nivel, decimal salario)
        {
            Id = id;
            NomeFuncionario = nomeFuncionario;
            Cargo = cargo;
            Nivel = nivel;
            Salario = salario;
        }
    }
}
