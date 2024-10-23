using System;
using System.Collections.Generic;
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
                Menu();
                Console.ReadKey();
            }
            catch (Exception)
            {

            }
        }



        //Menu De opções
        static void Menu()
        {
            Conta c = new Conta();

            //Opções
            Console.WriteLine($"== Saldo atual: R$ {c.Saldo} ==");
            Console.WriteLine("\n1. Efetuar Crédito em conta" +
                "\n2. Adicionar chaves favoritas" +
                "\n3. Listar chaves favoritas" +
                "\n4. Enviar PIX" +
                "\n5. Sair");

            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    c.CreditarConta(200);
                    Menu();
                    break;
                case 2:
                    c.AdicionarChaveFavorita("João Mateus", "Telefone", "51994646525");
                    Menu();
                    break;
                case 3:
                    c.ListarChavesFavoritas();
                    Menu();
                    break;
                case 4:
                    c.EnviarPix("51994646525", 100);
                    Menu();
                    break;
                case 5:
                    Console.WriteLine("Finalizando o programa, tenha um bom dia!");
                    break;
            }
        }
    }
}

