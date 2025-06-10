namespace instanciacaoApp
{
    public class Carro //class define os dados que o carro vai ter
    {
        public string Modelo;
        public int Ano;
    }

    internal class Program //class principal
    {
        static void Main()
        {
            Carro meuCarro = new Carro(); //instanciacao transforma em objeto
            meuCarro.Modelo = "Fusção Preto"; //agora pode receber valores
            meuCarro.Ano = 1980;

            //printa no console
            Console.WriteLine("O meu carro dos sonhos é:");
            Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}");
        }
    }
}
