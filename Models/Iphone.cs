namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone 
    {
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}