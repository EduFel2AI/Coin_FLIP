namespace CoinFlip.ViewModel;

public class ViewModel : ContentPage
{
    public class Coin
    {
        public string Lado { get; set; }

        public string jogar()
        {
            int ladoSorteado = new Random().Next(2);
            //o é cara
            //1 é coroa v
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            return (Lado);
        }

        public string jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            string resultado = Lado == ladoEscolhido ? "Você acertou!" : "Você errou!";
            return (resultado);
        }
    }
}