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

        static void UsarStreamDeEntrada()    
        {
            using(var fluxoDeEntrada = Console.OpenStandardInput())
            using(var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1026]; // 1 kb

                while(true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();

                    Console.WriteLine($"Byte lidos da console: {bytesLidos}");
                }

                //fluxoDeEntrada.Read
            }
        }
    }
}