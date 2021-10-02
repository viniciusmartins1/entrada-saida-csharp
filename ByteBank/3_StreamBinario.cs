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
        
        static void EscritaBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write(322); //Numero da Agência
                escritor.Write(342345); //Numero da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Gustavo Braga"); //Nome do Titular
            }
        }

        static void LeituraBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia} / {numero} {titular} {saldo}");
            }
        }
    }

}