using HandsOnChatBotWebAPI.Models;
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
        static ProdutoDAO()
        {
            var portepequeno = new PorteAnimal(1, "Porte Pequeno");
            var portemedio = new PorteAnimal(2, "Porte Medio");
            var portegrande = new PorteAnimal(3, "Porte Grande");
            var cachorro = new TipoAnimal(1, "Cachorro");
            var gato = new TipoAnimal(2, "Gato");
            var prod1 = new Produto(1,"Golden Formula Mini",90.00,"1 0quilo",cachorro,portepequeno);
            banco.Add(prod1);
            var prod2 = new Produto(2, "Royal Canin Mini", 164.00, "10 quilo", cachorro, portepequeno);
            banco.Add(prod2);
            var prod3 = new Produto(3, "Premier Pet Formula", 199.90, "10 quilos",cachorro, portemedio);
            banco.Add(prod3);
            var prod4 = new Produto(4, "Guabi Natural", 151.90, "10 quilo", cachorro, portemedio);
            banco.Add(prod4);
            var prod5 = new Produto(5, "Guabi Gran Plus", 104.90, "15 quilo", cachorro, portegrande);
            banco.Add(prod5);
            var prod6 = new Produto(6, "Magnus Todo Dia", 67.90, "15 quilo", cachorro, portegrande);
            banco.Add(prod6);
            var prod7 = new Produto(7, "Golden Gatos", 99.90, "10 quilo", gato, portepequeno);
            banco.Add(prod7);
            var prod8 = new Produto(8, "Adimax Magnus", 84.90, "10 quilo", gato, portepequeno);
            banco.Add(prod8);
            var prod9 = new Produto(9, "Total Max Cat", 156.50, "20 quilo", gato, portepequeno);
            banco.Add(prod9);

        }

        internal List<Produto> BuscaTodos()
        {
            return banco.ToList();
        }

        internal List<Produto> BuscaAnimal(int animal)
        {
            return banco.Where(x => x.Animal.Id == animal).ToList();
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
        public List<Produto> BuscaProdutos(int animal, int porte)
        {
            return banco.Where(x => x.Animal.Id == animal && x.Porte.Id == porte).ToList();
        }
    }
}