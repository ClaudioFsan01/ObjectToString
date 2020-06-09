using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine(" Entre com os dados do Produto \n");

            Console.WriteLine(" Entre com o nome do produto :");
            p.nome = Console.ReadLine();

            Console.WriteLine(" Entre com o preço do produto :");
            p.preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Entre com a quantidade em estoque do produto :");
            p.qtdEstoque = int.Parse(Console.ReadLine());

            mostrarProduto(p);

            Console.WriteLine(" Entre com a quantidade que será adicionada ao estoque : \n");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            mostrarProduto(p);

            Console.WriteLine(" Entre com a quantidade que será removida do estoque : \n");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            mostrarProduto(p);

            Console.Read();           

        }

        public static void mostrarProduto(Produto p)
        {
            Console.WriteLine(" Dados do produto :" + p);
        }
    }   
}



/* Classe CultureInfo : Fornece informações sobre uma cultura especifica. As informações incluem 
 * os nomes da cultura, o sistema de escrita, o calendario usado, a ordem de classificaçação da cadeia de 
 * caracteres e a formatação de datas e numeros. 
 * 
 * O método InvariantCulture : Obtem o objeto CultureInfo que é independente de cultura(invariavel) * 
   */

/* Toda classe em c# é uma subclasse da classe Object 
 * Object possui os seguintes métodos :
 * GetType - retorna o tipo do objeto 
 * Equals - compara se um objeto é igual ao outro
 * GetHashCode - retorna um codigo hash do objeto 


 */
