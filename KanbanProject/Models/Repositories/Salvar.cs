using System;
using System.IO;
using KanbanProject.Views.Shared;
using Newtonsoft.Json;
namespace KanbanProject.Models.Repositories
{
    class Salvar
    {
       public static void Caminho(Cliente cliente, string path)
        {
            var Json = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            GravarArquivo(path, Json);
        }
        public static void GravarArquivo(string path, string jsonString )
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString);
            }
            Painel.TextoVermelhoPerigo();
            Console.WriteLine(" Projeto Salvo!");
            Painel.TextoBranco();
        }
    }
}
