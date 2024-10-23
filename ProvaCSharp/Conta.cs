using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    class Conta
    {
        public decimal Saldo { get; set; }
        public List<string> listafavoritos = new List<string>();
        public int QuantidadePix = 0;
        public List<string> ListaDeContas = new List<string>();


        //Creditar o valor a conta do cliente
        public void CreditarConta(decimal strValor)
        {
            if (strValor < 0)
            {
                throw new CodigoDezException("Erro 20: Valor menor ou igual a zero.");
            }
            Saldo += strValor;
            Console.WriteLine($"Saldo atualizado: {Saldo}");

        }

        //Adicionar a chave do cliente aos favoritos
        public void AdicionarChaveFavorita(string stNome,string strTipo, string strChave)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(strTipo,strChave))
            listafavoritos.Add(stNome);
            listafavoritos.Add(strTipo);
            listafavoritos.Add(strChave);
        }

        //Mostra para o cliente as chaves que ele definiu como favoritas
        public void ListarChavesFavoritas()
        {
            foreach(var item in listafavoritos)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Valor total de pix feito para ");
                Console.WriteLine(" ");
            }
        }

        //Realiza o envio do pix
        public void EnviarPix(string strChave, decimal strValor)
        {

            Console.WriteLine("Digite o chave para o pix");
            strChave = Console.ReadLine();
            foreach(var item in listafavoritos) // Criar um método para isto
            {
                if (strChave == item)
                {
                    Console.WriteLine($"Chave Encontrada: {strChave}");
                }else
                {
                    Console.WriteLine("chave não encontrada");
                }//
            }
            Console.WriteLine("Digite o valor do Pix");
            strValor = decimal.Parse(Console.ReadLine());
            if (strValor > Saldo )
            {
                throw new CodigoDezException("Erro 10: Valor Inválido.");
            }
            Saldo -= strValor;


        }

        public void Persistir()
        {

        }


    }
}
