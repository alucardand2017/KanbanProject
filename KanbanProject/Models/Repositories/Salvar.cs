﻿using System;
using System.IO;
using Newtonsoft.Json;
namespace KanbanProject.Models.Repositories
{
    class Salvar
    {
        public static void Caminho(Cliente cliente)
        {
            Console.WriteLine("Defina o caminho do arquivo:" + @"C:\Temp");
            string caminhoArquivo = @"C:\Temp";
            Console.WriteLine("Defina o nome do arquivo: ArquivoPadrao");
            string nomeArquivo = @"\ArquivoPadrao.json";
            JsonSerializar(cliente, caminhoArquivo + nomeArquivo);
        }
       public static void JsonSerializar(Cliente cliente, string path)
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
        }
    }
}
