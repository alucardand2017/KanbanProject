using System;
using System.IO;
using Newtonsoft.Json;

namespace KanbanProject.Models.Repositories
{
    class Carregar
    {
        public static Cliente CaminhoCarregar()
        {
            //Console.WriteLine("Defina o caminho do arquivo:" + @"C:\Temp");
            string caminhoArquivo = @"C:\Temp";
            //Console.WriteLine("Defina o nome do arquivo:"+ @"\ArquivoPadrao.json");
            string nomeArquivo = @"\ArquivoPadrao.json";
            Cliente Json = JsonDesserializar(caminhoArquivo+ nomeArquivo);
            return Json;
        }
        public static Cliente JsonDesserializar(string path)
        {
            string strJson ="";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<Cliente>(strJson);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Arquivo não encontrado! " + e.Message); ;
            }
            return JsonConvert.DeserializeObject<Cliente>(strJson);
        }
    }
}

