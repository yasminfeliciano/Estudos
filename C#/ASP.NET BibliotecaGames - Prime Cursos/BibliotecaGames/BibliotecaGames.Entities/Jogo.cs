using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaGames.Entities
{
    public class Jogo:IntId
    {
        public double ValorPago { get; set; }
        public string Imagem { get; set; }
        public int DataCompra { get; set; }
    }
}
