using Loja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnChatBotWebAPI.DAO
{
    public class ProdutoDAO
    {
        private static List<Produto> banco = new List<Produto>();
        private static long contador = 1;
        static ProdutoDAO()
        {
            var prod1 = new Produto(1, "Video Game 1", 450.0, 1);
            banco.Add(prod1);
            var prod2 = new Produto(2, "Video Game 2", 460.0, 1);
            banco.Add(prod2);
            var prod3 = new Produto(3, "Video Game 3", 470.0, 1);
            banco.Add(prod3);
            var prod4 = new Produto(4, "Video Game 4", 480.0, 1);
            banco.Add(prod4);
            var prod5 = new Produto(5, "Video Game 5", 490.0, 1);
            banco.Add(prod5);

        }

        //public void Adiciona(Produto produto)
        //{
        //    contador++;
        //    produto.Id = contador;
        //    banco.Add(contador, produto);
        //}
        public Produto Busca(long id)
        {
            return (Produto)banco.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}