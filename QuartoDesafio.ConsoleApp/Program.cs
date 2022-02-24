using System;
using System.IO;

namespace QuartoDesafio.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tentativa antiga

            string[] digitos2 = new string[]
            {
                " __ \n"+
                "|  |\n"+
                "|__!\n",

                "    \n"+
                "   |\n"+
                "   !\n",

                " __ \n"+
                " __|\n"+
                "|__ \n",

                " __ \n"+
                " __|\n"+
                " __!\n",

                "    \n"+
                "|__|\n"+
                "   !\n",

                " __ \n"+
                "|__ \n"+
                " __!\n",

                " __ \n"+
                "|__ \n"+
                "|__!\n",

                " __ \n"+
                "   |\n"+
                "   !\n",

                " __ \n"+
                "|__|\n"+
                "|__!\n",

                " __ \n"+
                "|__|\n"+
                " __!\n",

            };


            string[] digitos = new string[10];


            digitos[0] = @"
 __ 
|  |
|__|";
            digitos[1] = @"
  
   |
   |";
            digitos[2] = @"
 __ 
 __|
|__ ";
            digitos[3] = @"
__ 
__|
__|";
            digitos[4] = @"
    
|__|
   |";
            digitos[5] = @"
 __ 
|__ 
 __|";
            digitos[6] = @"
 __ 
|__ 
|__|";
            digitos[7] = @"
 __ 
   |
   |";
            digitos[8] = @"
 __ 
|__|
|__|";
            digitos[9] = @"
 __ 
|__|
 __|";

            for (int i = 0; i < digitos2.Length; i++)
            {
                Console.Write(digitos2[i]);
            }

            string entrada = " __  __  __  __  __      __  __     \n" +
                             "|__ |__    ||__||__|   | __| __||__|\n" +
                             " __||__|   ||__| __|   ||__  __|   |\n" +
                             "                                    \n" +
                             " __      __  __      __  __  __  __ \n" +
                             " __||__|   ||__|   | __||__ |__ |__|\n" +
                             " __|   |   ||__|   ||__  __||__| __|\n" +
                             "                                    \n" +
                             " __  __  __  __  __      __  __     \n" +
                             " __| __||__ |__ |__||__|   ||__|   |\n" +
                             " __||__  __||__| __|   |   ||__|   |\n" +
                             "                                    \n" +
                             " __  __  __  __  __  __      __     \n" +
                             "|  | __||__ |__    ||__|  | |__||__|\n" +
                             "|__||__  __||__|   ||__|  |  __|   |\n";




            #endregion


            string texto = "     __  __      __  __ __   __  __  __ \n" +
                           "  |  __| __||__||__ |__   | |__||__||  |\n" +
                           "  | |__  __|   | __||__|  | |__| __||__|\n";


            StringReader leitorTexto = new StringReader(entrada);

            string primeiraLinhaDeCaracteresDosDigitos = leitorTexto.ReadLine();

            string segundaLinhaDeCaracteresDosDigitos = leitorTexto.ReadLine();

            string terceiraLinhaDeCaracteresDosDigitos = leitorTexto.ReadLine();

            char[] arrayDeCaracteresDaLinha1DosDigitos = primeiraLinhaDeCaracteresDosDigitos.ToCharArray();

            char[] arrayDeCaracteresDaLinha2DosDigitos = segundaLinhaDeCaracteresDosDigitos.ToCharArray();

            char[] arrayDeCaracteresDaLinha3DosDigitos = terceiraLinhaDeCaracteresDosDigitos.ToCharArray();

            string caracteresDaLinha1DigitoAtual = "", caracteresDaLinha2DigitoAtual = "", caracteresDaLinha3DigitoAtual = "";

            int cont = 0;

            for (int i = 0; i < 40; i++)
            {
                caracteresDaLinha1DigitoAtual += arrayDeCaracteresDaLinha1DosDigitos[i];
                caracteresDaLinha2DigitoAtual += arrayDeCaracteresDaLinha2DosDigitos[i];
                caracteresDaLinha3DigitoAtual += arrayDeCaracteresDaLinha3DosDigitos[i];

                if (caracteresDaLinha1DigitoAtual == "    " && caracteresDaLinha2DigitoAtual == "   |" && caracteresDaLinha3DigitoAtual == "   |")
                {
                    Console.Write("1");
                }
                if (caracteresDaLinha1DigitoAtual == "    " && caracteresDaLinha2DigitoAtual == "  | " && caracteresDaLinha3DigitoAtual == "  | ")
                {
                    Console.Write("1");
                }

                //string numero = VerificaERetornaDigito(caracteresDaLinha1DigitoAtual, caracteresDaLinha2DigitoAtual, caracteresDaLinha3DigitoAtual, digitos2);

                //Console.Write(numero);

                cont += 1;

                if (cont == 4)
                {
                    caracteresDaLinha1DigitoAtual = "";
                    caracteresDaLinha2DigitoAtual = "";
                    caracteresDaLinha3DigitoAtual = "";
                    cont = 0;
                }

            }


            //#region Tentativas antigas
            //string[] linhas = entrada.Split("\r\n");


            ////for (int i = 0; i < linhas.length; i++)
            ////{
            ////    console.writeline("linha {0}: {1}", i, linhas[i]);
            ////}

            //string digitoAtual = "";
            ////for (int i = 0; i < linhas.length; i++)
            ////{
            ////    if (linhas[i] != "" && linhas[i] != " ")
            ////    {
            ////        for (int coluna = 0; coluna < 4; coluna++)
            ////        {
            ////            digitoatual += linhas[coluna];
            ////        }
            ////        console.writeline(digitoatual);
            ////        digitoatual = "";
            ////    }
            ////}
            //string p1 = "", p2 = "", p3 = "", p4 = "";





            //for (int linhaGeral = 0; linhaGeral < linhas.Length; linhaGeral = linhaGeral + 4)
            //{
            //    if (linhaGeral < 16)
            //    {
            //        for (int coluna = 0; coluna < 36; coluna = coluna + 4)
            //        {

            //            for (int linhaAtual = linhaGeral; linhaAtual < (linhaAtual + 4); linhaAtual++)
            //            {
            //                if (linhas[linhaAtual].Length == 36 && coluna != 36)
            //                {
            //                    //Console.WriteLine("digito atual");
            //                    p1 += linhas[linhaAtual].Substring(coluna, coluna + 4);
            //                    //Console.WriteLine(p1);
            //                    digitoAtual = p1;
            //                    for (int i = 0; i < digitos.Length; i++)
            //                    {
            //                        if (digitoAtual == digitos[i])
            //                        {
            //                            Console.WriteLine(i);
            //                            break;
            //                        }
            //                    }

            //                }

            //                p1 = "";
            //            }
            //        }



            //        //for (int linhaGeral = 0; linhaGeral < linhas.Length; linhaGeral = linhaGeral + 4)
            //        //{
            //        //    Console.WriteLine(linhaGeral);
            //        //    for (int linhaAtual = linhaGeral; linhaAtual < linhaGeral + 4; linhaAtual++)
            //        //    {
            //        //        Console.WriteLine(linhaAtual);
            //        //        if (linhas[linhaAtual].Length == 36)
            //        //        {
            //        //            for (int colunaGeral = 0; colunaGeral < 36; colunaGeral = colunaGeral + 4)
            //        //            {
            //        //                Console.WriteLine("k");
            //        //            }
            //        //        }
            //        //    }
            //        //    Console.WriteLine("-------------------");
            //        //}

            //        #endregion 




        }

        static string VerificaERetornaDigito(string digitoAtualLinha1, string digitoAtualLinha2, string digitoAtualLinha3, string[] digitosBase)
        {
            string digitoAtual = string.Join('\n', digitoAtualLinha1, digitoAtualLinha2, digitoAtualLinha3);

            string retorno = "";

            for (int i = 0; i < digitosBase.Length; i++)
            {
                if (digitoAtual == digitosBase[i])
                {
                    retorno = Convert.ToString(i);

                    break;
                }
            }

            return retorno;

        }

    }
}





