namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    using DesafioPOO.Models;
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Insalando aplicativo {nomeApp} no Iphone");
        }
    }
}