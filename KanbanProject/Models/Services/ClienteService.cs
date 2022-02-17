using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanbanProject.Models;
using KanbanProject.Models.Enums;

namespace KanbanProject.Models.Services
{
    static class ClienteService
    {  
        public static void CadastrarCliente( List<Cliente> clientes)
        {
            Console.WriteLine("Cadastrar novo Cliente");
            Console.Write("Inserir Nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Inserir Endereço do Cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("Inserir telefone do Cliente: ");
            string telefone = Console.ReadLine();
            Cliente c = new Cliente(nome, endereco, telefone);
            clientes.Add(c);
        }
    }
}
