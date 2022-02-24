using System;

namespace InterpretadordeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Definição dos dígtos de base para comparação
            string[] digitos = new string[]
           {
                " __ \n"+
                "|  |\n"+
                "|__|",

                "    \n"+
                "   |\n"+
                "   |",

                " __ \n"+
                " __|\n"+
                "|__ ",

                " __ \n"+
                " __|\n"+
                " __|",

                "    \n"+
                "|__|\n"+
                "   |",

                " __ \n"+
                "|__ \n"+
                " __|",

                " __ \n"+
                "|__ \n"+
                "|__|",

                " __ \n"+
                "   |\n"+
                "   |",

                " __ \n"+
                "|__|\n"+
                "|__|",

                " __ \n"+
                "|__|\n"+
                " __|",

           };

            #endregion

            #region Entrada de dados

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
                             "|  | __||__ |__    ||__|   ||__||__|\n" +
                             "|__||__  __||__|   ||__|   | __|   |";
            
            #endregion

            #region Processamento

            string[] todasAsLinhasDeCaracteresDaEntrada = entrada.Split('\n');

            string resultado = "";

            for (int i = 0; i < todasAsLinhasDeCaracteresDaEntrada.Length; i = i + 4)
            {
                string linhaDeCaracteresAtual = todasAsLinhasDeCaracteresDaEntrada[i];

                string linhaDeCaracteresSeguinte = todasAsLinhasDeCaracteresDaEntrada[i + 1];

                string linhaDeCaracteresFinal = todasAsLinhasDeCaracteresDaEntrada[i + 2];

                string linha1DigitoAtual = "";

                string linha2DigitoAtual = "";

                string linha3DigitoAtual = "";


                for (int j = 0; j < 36; j = j + 4)
                {
                    linha1DigitoAtual = linhaDeCaracteresAtual.Substring(j, 4);
                    linha2DigitoAtual = linhaDeCaracteresSeguinte.Substring(j, 4);
                    linha3DigitoAtual = linhaDeCaracteresFinal.Substring(j, 4);

                    string numero = VerificaERetornaDigito(linha1DigitoAtual, linha2DigitoAtual, linha3DigitoAtual, digitos);

                    resultado += numero;

                    linha1DigitoAtual = "";
                    linha2DigitoAtual = "";
                    linha3DigitoAtual = "";

                }

                resultado += "\n";

            }
            #endregion

            #region Saída de dados

            Console.WriteLine("Entrada:\n");
            Console.WriteLine(entrada);
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nSaída:\n");
            Console.WriteLine(resultado);

            #endregion
        }

        #region Métodos

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

        #endregion
    }
}
