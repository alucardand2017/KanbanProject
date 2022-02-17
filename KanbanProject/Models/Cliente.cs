using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KanbanProject.Models
{
    public class Cliente
    {
        public List<Projeto> Projetos { get; set; } = new List<Projeto>();
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string  Telefone { get; set; }
        public Cliente()
        {
        }
        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
        public void PrintProjetos()
        {
            int count = 1;
            foreach (var item in Projetos)
            { 
                System.Console.WriteLine($"Projeto {count}" +item.NomeProjeto);
                count++;
            }
        }
        public override string ToString()
        {
            return
                "\n\nNome: " +
                Nome +
                "\n" +
                "Endereço: " +
                Endereco +
                "\n" +
                "Telefone: " +
                Telefone; 
           
        }
    }
}