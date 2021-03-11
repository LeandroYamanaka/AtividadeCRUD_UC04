using System.Collections.Generic;

namespace Atividade_2.Models
{
    public class Pacote
    {
        public int IdPacote { get; set; }
        public string Destino { get; set; }
        public string Partida { get; set; }
        public string Saida { get; set; }
        public string Retorno { get; set; }
        public double Preco { get; set; }
        public int Usuario { get; set; }


    }
}