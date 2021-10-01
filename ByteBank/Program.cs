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
        static void Main(string[] args)
        {
            
           //CriarArquivo();

           CriarArquivoComWriter();
           Console.WriteLine("Aplicação finalizada");
        }
       
    }
}
