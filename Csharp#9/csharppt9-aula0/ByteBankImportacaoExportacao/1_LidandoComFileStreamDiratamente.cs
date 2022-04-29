using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    // Partial class
    // para usar indicando que temos métodos e partes de uma
    //  classe em outros arquivos
    // Nessa caso o arquivo Program.cs
    partial class Program
    {
        #region Métodos

        #region FileStream Diretamente
        static void LidandoComFilesStreamDiretamente()
        {
           #region Comentário
            /* Versão com Try catch e finally 
                
                var endereçoDoArquivo = "contas.txt"

                try
                {
                    var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

                    var buffer = new byte[1024]; // 1 kb
                    var numeroDeBytesLidos = -1;

                    while (numeroDeBytesLidos ! =0)
                    {
                        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0,1024);
                        EscreverBuffer(buffer);
                    }

                    fluxoDoArquivo.Close();

                }
                finally
                {
                    if(fluxoDoArquivo != null){
                        fluxoDoArquivo.Close();
            
                    }
            
                }
            */
            #endregion
            var enderecodoArquivo = "contas.txt";
            //FileMode é um enum e Open um dos seus valores
            using (var fluxoDoArquivo = new FileStream(enderecodoArquivo, FileMode.Open))
            {

                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;

                //Reutilizando o Buffer com o while para imprimir o arquivo que tem mais 
                // que 1024 kb

                while (numeroDeBytesLidos != 0)
                {
                    //Leitura dos bytes
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes Lidos {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);// colocando para escrever os dados até o final do arquivo
                }

                // Com o using não precisa do Close, já faz automaticamente como método Dispose

                // fluxoDoArquivo.Close(); // Fechando o arquivo e liberando o buffer
            }
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            //Usando Econding para decodificar o arquivo 
            var utf8 = new UTF8Encoding();
            var utf82 = Encoding.Default; // Também funciona


            var texto = utf8.GetString(buffer, 0, bytesLidos);

            //Apresentando os dados do arquivo agora em texto
            Console.Write(texto);
            //Primeiro método descartado
            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write("");
            //}
        }
        #endregion
        #region Exercicio
        static void Exec01()
        {
            var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);

            var buffer = new byte[1024];
            var encoding = Encoding.ASCII;

            var bytesLidos = fs.Read(buffer, 0, 1024);
            var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

            Console.Write(conteudoArquivo);
        }
        #endregion

        #region Enum
        static void TestaEnum()
        {

            //Enums Teste Classe Botão
            var btnCancelar = new Botao();
            btnCancelar.Texto = "Cancelar";
            btnCancelar.cor = (int)CoresBotao.Verde;

            /*
            E enums são fortemente tipados! Em variáveis ou
            propriedades do tipo 
            CoresBotao só podemos usar valores definidos neste enum: 
            */

            //CoresBotao cor1 = "Azul"; Não compila
            CoresBotao cor2 = CoresBotao.Azul;

            //Não compila abaixo cast entre string e Enum não é permitido

            //var linhaDeTextoDoArquivo = "Azul";
            //CoresBotao cor1 = linhaDeTextoDoArquivo; // nao compila

            //var linhaDeTextoDorquivo = "Azul";
            //CoresBotao cor1 = (CoresBotao)linhaDeTextoDorquivo;

            //Abaixo funciona cast entre inteiros
            var numero = 0;
            CoresBotao cor1 = (CoresBotao)numero; // Compila!

            Console.WriteLine(CoresBotao.Azul == (CoresBotao)128); // escreve True
            Console.WriteLine(CoresBotao.Vermelho == (CoresBotao)256); // escreve True
            Console.WriteLine(CoresBotao.Verde == (CoresBotao)512); // escreve True

            Console.WriteLine(CoresBotao.Verde == (CoresBotao)1); // escreve False e não lança exceção 
        }
        #endregion

        #endregion
    }
}



