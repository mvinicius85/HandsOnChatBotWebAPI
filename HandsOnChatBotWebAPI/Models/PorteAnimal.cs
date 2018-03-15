using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnChatBotWebAPI.Models
{
    public class PorteAnimal
    {
        public PorteAnimal()
        {

        }

        public PorteAnimal(int _id, string _desc)
        {
            Id = _id;
            Descricao = _desc;
        }
        public int Id { get; set; }
        public String Descricao { get; set; }
    }
}