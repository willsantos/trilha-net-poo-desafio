namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }


        public Smartphone(string numero, int memoria, string imei, string modelo)
        {
            Numero = numero;
            Memoria = memoria;
            Imei = imei;
            Modelo = modelo;
        }

        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}