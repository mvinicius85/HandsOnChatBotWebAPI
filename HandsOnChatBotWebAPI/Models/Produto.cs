using HandsOnChatBotWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using a = System.CannotUnloadAppDomainException;

namespace Loja.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public TipoAnimal Animal { get; set; }
        public PorteAnimal Porte { get; set; }

        public Produto()
        {

        }

        public Produto(long id, string nome, double preco, string unidade, TipoAnimal animal, PorteAnimal porte)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Unidade = unidade;
            this.Animal = animal;
            this.Porte = porte;
        }
    }
}
