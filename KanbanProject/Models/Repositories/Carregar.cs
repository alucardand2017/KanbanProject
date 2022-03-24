using System;
using System.IO;
using Newtonsoft.Json;

namespace KanbanProject.Models.Repositories
{
    class Carregar
    {
        public static Cliente CaminhoCarregar(string fullpath)
        {           
            Cliente Json = JsonDesserializar(fullpath);
            return Json;
        }
        private static Cliente JsonDesserializar(string path)
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

