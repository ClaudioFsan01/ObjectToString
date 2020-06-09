using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ObjectToString
{
    class Produto
    {
        public String nome;
        public double preco;
        public int qtdEstoque;


        public double ValorTotalEmEstoque()
        {
            return preco * qtdEstoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            qtdEstoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if(quantidade <= qtdEstoque)
            {
                qtdEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine(" Quantidade no estoque menor que a solicitada ! \n");
            }

          
        }

        //Sobreposição 

        // A palavra  override indica que esta operação vem de outra classe 

        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return nome +
                ", $ " +
                preco.ToString("F2 ", CultureInfo.InvariantCulture) +
                qtdEstoque +
                " unidade, total : $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        /* * ToString - converte um objeto para String  
        * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/

    }
}
