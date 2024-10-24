using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Conta c = new Conta();
                    Menu(c);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    Console.ReadKey();
                }
            
        }

        //Menu De opções
        static void Menu(Conta c)
        {

            //Opções
            Console.WriteLine($"== Saldo atual: R$ {c.Saldo} ==");
            Console.WriteLine("\n1. Efetuar Crédito em conta" +
                "\n2. Adicionar chaves favoritas" +
                "\n3. Listar chaves favoritas" +
                "\n4. Enviar PIX" +
                "\n5. Sair");
            Console.Write("Informe a opção desejada: ");

            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                //Realiza a operação de Efetuar o crédito na conta
                case 1:
                    Console.Write("Digite o valor a ser adicionado: ");
                    Decimal ValorInput = decimal.Parse(Console.ReadLine());
                    c.CreditarConta(ValorInput);
                    Console.WriteLine("Sucesso!\n");
                    Menu(c);
                    break;
                //Realiza a operação de Efetuar o crédito na conta
                case 2:
                    Console.Write("Digite o nome do titular: ");
                    string InputNomeTitular = Console.ReadLine();
                    Console.Write("\nTipo da chave: ");
                    string InputTipoDaChave = Console.ReadLine().ToLower();
                    Console.Write("\nDigite a chave: ");
                    string InputChave = Console.ReadLine();
                    c.AdicionarChaveFavorita(InputNomeTitular, InputTipoDaChave, InputChave);
                    Console.WriteLine("Chave Adicionada!\n");
                    Menu(c);
                    break;
                //Realiza a operação Mostrar os registros realizados de acordo com a chave escolhida
                case 3:
                    Console.WriteLine("------  Registros -------");
                    c.ListarChavesFavoritas();
                    Console.WriteLine("------  Registros -------\n");
                    Menu(c);
                    break;
                //Realiza a operação de PIX
                case 4:
                    Console.Write("Digite a chave: ");
                    string Chave = Console.ReadLine();
                    Console.WriteLine("Digite o valor a enviado:");
                    Decimal ValorPix = decimal.Parse(Console.ReadLine());
                    c.EnviarPix(Chave, ValorPix);
                    Console.WriteLine($"Pix de {ValorPix} Realizado com sucesso!\n");
                    Menu(c);
                    break;
                case 5:
                    Console.WriteLine("Finalizando o programa, tenha um bom dia!");
                    break;
            }
        }
    }
}

