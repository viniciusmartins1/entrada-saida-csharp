using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBank
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var enderecoDoArquivo = "contas.txt";

            using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo))
            {
                while(!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }

            
        }
       
    }
}
