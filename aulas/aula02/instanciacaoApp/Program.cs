namespace instanciacaoApp
{
    public class Carro //class define os dados que o carro vai ter
    {
        public string Modelo;
        public int Ano;
        public string Marca;
    }

    internal class Program //class principal
    {
        static void Main()
        {
            Carro meuCarro = new Carro(); //instanciacao transforma em objeto
            meuCarro.Modelo = "Fuscão Preto"; //agora pode receber valores
            meuCarro.Ano = 1980;
            meuCarro.Marca = "Volkswagen";

            //printa no console
            Console.WriteLine("O meu carro dos sonhos é:");
            Console.WriteLine($"Modelo: {meuCarro.Modelo}, Marca: {meuCarro.Marca}, Ano: {meuCarro.Ano}");

            //isso impede que o console feche imediatamente
            Console.ReadLine();
        }
    }
}
