using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankImportacaoExportacao;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBank
{
    partial class Program
    {

        static void CriarArquivo()
        {
            
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "234,423524,34234.43, Gustavo Santos";
                var  encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
                                                                                                    
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("342, 34234, 434.0, Vinicius Martins");
            }
            
        }

        static void TesteEcrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10; i++)       
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush();

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p  adicionar mais linha");
                    Console.ReadLine();

                }
                 
            }
           
        }
    }

}