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
    }

}