namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int memoria, string imei, string modelo) : base(numero,memoria,imei,modelo)
        {
        }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo{nomeApp} no IOs...");
        }
    }
}