using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        //Propriedade ->  escrever Prop, enter e alterar o tipo e o nome Lado
        public string Lado { get; set; }

        public string Jogar()
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";
            return(Lado);
        }
        public string Jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";
            string resultado = Lado == ladoEscolhido ?
                $"Parabéns, você pediu {ladoEscolhido} e deu {Lado}" :
                $"Que pena, você pediu {ladoEscolhido} e deu {Lado}";
            return (resultado);
        }
    }
}
