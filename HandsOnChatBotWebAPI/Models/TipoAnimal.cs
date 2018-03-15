using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnChatBotWebAPI.Models
{
    public class TipoAnimal
    {
        public TipoAnimal()
        {

        }

        public TipoAnimal(int _id, string _desc)
        {
            Id = _id;
            Descricao = _desc;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}